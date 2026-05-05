using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AppointmentHemo
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AppointmentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AppointmentDateTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AppointmentTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VisitTypeCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MachineCode { get; set; }

    public byte? OperativeTime { get; set; }

    public int StatusID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tittle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhoneNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmailAddress { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string EntryBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EntryDateTime { get; set; }

    public bool IsAllowSms { get; set; }

    public bool IsAllowContact { get; set; }

    public bool IsAllowEmail { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
