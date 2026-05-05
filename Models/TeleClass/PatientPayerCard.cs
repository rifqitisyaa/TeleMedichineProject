using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "MedicalNo", "CardNo")]
public partial class PatientPayerCard
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string CardNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? CardType { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("PatientPayerCard")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientPayerCard")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
