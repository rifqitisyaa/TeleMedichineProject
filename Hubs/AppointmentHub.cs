using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace TeleMedichineProject.Hubs
{
    public class AppointmentHub : Hub
    {
        // Dokter/admin join ke group workstation masing-masing
        // sehingga notifikasi hanya masuk ke workstation yang relevan
        public async Task JoinWorkstation(string workstationCode)
        {
            if (!string.IsNullOrEmpty(workstationCode))
                await Groups.AddToGroupAsync(Context.ConnectionId, $"ws_{workstationCode}");
        }

        public async Task LeaveWorkstation(string workstationCode)
        {
            if (!string.IsNullOrEmpty(workstationCode))
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"ws_{workstationCode}");
        }

        // Join group "all" untuk halaman Index (admin melihat semua)
        public async Task JoinAll()
            => await Groups.AddToGroupAsync(Context.ConnectionId, "all");

        public async Task TestConnection()
        {
            await Clients.Caller.SendAsync("NewRegistration", new {
                appointmentNo = "TEST-001",
                patientName = "TEST SIGNALR OK",
                registrationNo = "REG-TEST",
                workStation = "WS-TEST",
                time = DateTime.Now.ToString("HH:mm"),
                encryptedAptNo = "TEST",
                hasWorkstation = true,
                appointmentDate = DateTime.Now.ToString("dd-MM-yyyy")
            });
        }
    }
}
