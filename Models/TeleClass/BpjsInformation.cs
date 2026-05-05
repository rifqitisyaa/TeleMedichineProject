using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BpjsInformation
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ProvinceKkl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KabupatenKkl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KecamatanKkl { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
