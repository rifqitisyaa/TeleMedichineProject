using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DetailNo")]
public partial class IcuIndicatorDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GcIcuIndicator { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Value { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GcIcuIndicator")]
    [InverseProperty("IcuIndicatorDt")]
    public virtual sysGeneralCode GcIcuIndicatorNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("IcuIndicatorDt")]
    public virtual IcuIndicatorHd IcuIndicatorHd { get; set; } = null!;
}
