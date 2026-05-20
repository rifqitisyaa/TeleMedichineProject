using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Hubs;
using TeleMedichineProject.Models.TeleClass;
using TeleMedichineProject.Helpers;

namespace TeleMedichineProject.Services;

public class AppointmentWatcherService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IHubContext<AppointmentHub> _hubContext;
    private readonly HashSet<string> _lastSeenApts = new();
    private bool _isFirstRun = true;

    public AppointmentWatcherService(IServiceProvider serviceProvider, IHubContext<AppointmentHub> hubContext)
    {
        _serviceProvider = serviceProvider;
        _hubContext = hubContext;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Tunggu sebentar saat startup agar DB ready
        await Task.Delay(5000, stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<ErcDbContext>();

                var today = DateTime.Today;
                
                // Ambil data appointment hari ini
                var currentApts = await db.Appointment
                    .AsNoTracking()
                    .Where(a => !a.IsDeleted && a.AppointmentDateTime.Date == today)
                    .Select(a => new { 
                        a.AppointmentNo, 
                        PatientName = a.PatientName ?? (a.FirstName + " " + a.LastName).Trim(), 
                        a.WorkStationCode, 
                        a.AppointmentDateTime 
                    })
                    .ToListAsync(stoppingToken);

                // Ambil data yang sudah terregistrasi
                var registeredNos = await db.Registration
                    .AsNoTracking()
                    .Where(r => !r.IsDeleted && r.RegistrationDateTime.Date == today)
                    .Select(r => r.AppointmentNo)
                    .ToListAsync(stoppingToken);

                var unregisteredApts = currentApts
                    .Where(a => !registeredNos.Contains(a.AppointmentNo))
                    .ToList();

                if (_isFirstRun)
                {
                    // Inisialisasi cache awal agar tidak membroadcast data lama saat startup
                    foreach (var a in unregisteredApts) _lastSeenApts.Add(a.AppointmentNo);
                    _isFirstRun = false;
                }
                else
                {
                    foreach (var apt in unregisteredApts)
                    {
                        if (!_lastSeenApts.Contains(apt.AppointmentNo))
                        {
                            // BROADCAST: Ada data baru dari aplikasi sebelah!
                            var notif = new
                            {
                                appointmentNo = apt.AppointmentNo,
                                patientName = apt.PatientName,
                                time = DateTime.Now.ToString("HH:mm"),
                                encryptedAptNo = EncryptHelper.Encrypt(apt.AppointmentNo),
                                hasWorkstation = !string.IsNullOrWhiteSpace(apt.WorkStationCode),
                                appointmentDate = apt.AppointmentDateTime.ToString("d-M-yyyy")
                            };

                            await _hubContext.Clients.Group("all").SendAsync("NewRegistration", notif, stoppingToken);
                            _lastSeenApts.Add(apt.AppointmentNo);
                        }
                    }
                    
                    // Sinkronisasi cache: Hapus yang sudah terdaftar
                    var currentNos = unregisteredApts.Select(x => x.AppointmentNo).ToHashSet();
                    _lastSeenApts.RemoveWhere(no => !currentNos.Contains(no));
                }
            }
            catch (Exception)
            {
                // Silent error
            }

            await Task.Delay(5000, stoppingToken); // Cek database setiap 5 detik
        }
    }
}
