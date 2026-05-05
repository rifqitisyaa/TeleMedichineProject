using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Master_ChartOfAccount
{
    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaHeaderCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CoaName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CoaNameOtherLanguage { get; set; }

    public byte CoaLevel { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountTypeName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountTypeName2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string NormalPosition { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountRecordGroupName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountRecordGroupName2 { get; set; }

    public bool? IsCashFlow { get; set; }

    public bool IsCashBank { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
