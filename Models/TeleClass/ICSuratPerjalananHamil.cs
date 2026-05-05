using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ICSuratPerjalananHamil
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Diagnosa { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
