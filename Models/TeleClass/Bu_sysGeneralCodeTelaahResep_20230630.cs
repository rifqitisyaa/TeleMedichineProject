using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Bu_sysGeneralCodeTelaahResep_20230630
{
    [StringLength(20)]
    [Unicode(false)]
    public string GeneralCodeID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string GeneralCodeName1 { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string GeneralCodeName2 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    public bool IsHeader { get; set; }

    public bool IsUsedBySystem { get; set; }

    public bool IsActive { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
