using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Code", "FieldName")]
public partial class BarcodeSettingDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    public int OrderNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("Code")]
    [InverseProperty("BarcodeSettingDt")]
    public virtual BarcodeSettingHd CodeNavigation { get; set; } = null!;
}
