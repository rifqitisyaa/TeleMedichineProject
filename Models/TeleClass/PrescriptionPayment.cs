using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PrescriptionPayment
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPaymentType { get; set; }

    public int? ServiceUnitID { get; set; }

    public int? RoomID { get; set; }

    public int? BusinessPartnerID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("PrescriptionPayment")]
    public virtual BusinessPartner? BusinessPartner { get; set; }

    [ForeignKey("GCPaymentType")]
    [InverseProperty("PrescriptionPayment")]
    public virtual sysGeneralCode? GCPaymentTypeNavigation { get; set; }

    [ForeignKey("JobOrderNo")]
    [InverseProperty("PrescriptionPayment")]
    public virtual JobOrderHd JobOrderNoNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PrescriptionPayment")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("RoomID")]
    [InverseProperty("PrescriptionPayment")]
    public virtual ServiceRoom? Room { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("PrescriptionPayment")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }
}
