using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratPernyataanPulangAtasPermintaanSendiri
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Unicode(false)]
    public string? FamilyName { get; set; }

    [Unicode(false)]
    public string? FamilyAge { get; set; }

    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [Unicode(false)]
    public string? Address { get; set; }

    [Unicode(false)]
    public string? Hubungan { get; set; }

    [Unicode(false)]
    public string? Reason { get; set; }

    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
