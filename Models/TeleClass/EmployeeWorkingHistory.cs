using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeWorkingHistory
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocumentDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GcType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PositionCodeFrom { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string OrganitationCodeFrom { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GcEmployeeStatusFrom { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PositionCodeTo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string OrganitationCodeTo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GcEmployeeStatusTo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDateFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDateTo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndeffectiveDate { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeWorkingHistory")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("GcEmployeeStatusFrom")]
    [InverseProperty("EmployeeWorkingHistoryGcEmployeeStatusFromNavigation")]
    public virtual sysGeneralCode GcEmployeeStatusFromNavigation { get; set; } = null!;

    [ForeignKey("GcEmployeeStatusTo")]
    [InverseProperty("EmployeeWorkingHistoryGcEmployeeStatusToNavigation")]
    public virtual sysGeneralCode GcEmployeeStatusToNavigation { get; set; } = null!;

    [ForeignKey("GcType")]
    [InverseProperty("EmployeeWorkingHistoryGcTypeNavigation")]
    public virtual sysGeneralCode GcTypeNavigation { get; set; } = null!;

    [ForeignKey("OrganitationCodeFrom")]
    [InverseProperty("EmployeeWorkingHistoryOrganitationCodeFromNavigation")]
    public virtual Organization OrganitationCodeFromNavigation { get; set; } = null!;

    [ForeignKey("OrganitationCodeTo")]
    [InverseProperty("EmployeeWorkingHistoryOrganitationCodeToNavigation")]
    public virtual Organization OrganitationCodeToNavigation { get; set; } = null!;

    [ForeignKey("PositionCodeFrom")]
    [InverseProperty("EmployeeWorkingHistoryPositionCodeFromNavigation")]
    public virtual Position PositionCodeFromNavigation { get; set; } = null!;

    [ForeignKey("PositionCodeTo")]
    [InverseProperty("EmployeeWorkingHistoryPositionCodeToNavigation")]
    public virtual Position PositionCodeToNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("EmployeeWorkingHistory")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("EmployeeWorkingHistory")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
