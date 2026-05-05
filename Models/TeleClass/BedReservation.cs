using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BedReservation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReservationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EntryDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string EntryBy { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int? BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmailAddress { get; set; }

    public bool IsByPhone { get; set; }

    public bool IsBySms { get; set; }

    public bool IsByEmail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCReservationStatus { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReservationDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

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

    [ForeignKey("BedID")]
    [InverseProperty("BedReservation")]
    public virtual Bed? Bed { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("BedReservation")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("GCReservationStatus")]
    [InverseProperty("BedReservationGCReservationStatusNavigation")]
    public virtual sysGeneralCode GCReservationStatusNavigation { get; set; } = null!;

    [ForeignKey("GCSex")]
    [InverseProperty("BedReservationGCSexNavigation")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("BedReservation")]
    public virtual Patient? MedicalNoNavigation { get; set; }

    [InverseProperty("ReservationNoNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [ForeignKey("SiteCode")]
    [InverseProperty("BedReservation")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("BedReservation")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
