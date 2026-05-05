using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProjectMCUNo", "SequenceNo")]
public partial class ImportMCUCorporate
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProjectMCUNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? AppointmentMCUNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AppointmentDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string EmployeeName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [Unicode(false)]
    public string? Division { get; set; }

    [Unicode(false)]
    public string? Position { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBloodType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BloodRhesus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCNationality { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string MobilePhoneNumber { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SSN { get; set; }

    [Unicode(false)]
    public string? UnparticipantReason { get; set; }

    public bool IsManualRegistration { get; set; }

    public bool IsCompileMCUApproved { get; set; }

    public bool IsRealization { get; set; }

    public bool IsResultFinished { get; set; }

    public bool IsGeneratedFilter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GeneratedDateTime { get; set; }

    public bool? IsCancel { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCNationality")]
    [InverseProperty("ImportMCUCorporate")]
    public virtual sysGeneralCode GCNationalityNavigation { get; set; } = null!;

    [ForeignKey("ItemCode")]
    [InverseProperty("ImportMCUCorporate")]
    public virtual Item ItemCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ImportMCUCorporate")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ImportMCUCorporate")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
