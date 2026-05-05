using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "GeneralCodeID")]
public partial class TelaahResepDetail
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GeneralCodeID { get; set; } = null!;

    public bool? TelaahResepObatYa { get; set; }

    public bool? TelaahResepObatTidak { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
