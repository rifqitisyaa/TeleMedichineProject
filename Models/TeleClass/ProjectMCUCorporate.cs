using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ProjectMCUCorporate
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProjectMCUNo { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Unicode(false)]
    public string? ProjectMCUSummary { get; set; }

    public int TotalEmployee { get; set; }

    public int TotalRegister { get; set; }

    public int TotalManualRegistration { get; set; }

    public int TotalCompileMCUApproved { get; set; }

    public int TotalRealization { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndingDate { get; set; }

    public bool IsClosed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ProjectMCUCorporate")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("DocumentNo")]
    [InverseProperty("ProjectMCUCorporate")]
    public virtual CustomerContract DocumentNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ProjectMCUCorporate")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ProjectMCUCorporate")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
