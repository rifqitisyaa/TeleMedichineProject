using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientBirthRecord
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MotherRegistrationNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MotherMedicalNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDeliveryLocation { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDeliveryMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCaesarMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBornCondition { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCParamedicType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCStatusRLPerinatology { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PhysicianName { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal PregnancyWeek { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal Length { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Weight { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal APGARScore1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal APGARScore2 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal APGARScore3 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal HeadCircumference { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NewBornAnalisis { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? CordBloodGasesPH { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? CordBloodGasesBaseExcess { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? BloodSugar { get; set; }

    public byte? NIPS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MotherName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FatherName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCBornCondition")]
    [InverseProperty("PatientBirthRecordGCBornConditionNavigation")]
    public virtual sysGeneralCode? GCBornConditionNavigation { get; set; }

    [ForeignKey("GCCaesarMethod")]
    [InverseProperty("PatientBirthRecordGCCaesarMethodNavigation")]
    public virtual sysGeneralCode? GCCaesarMethodNavigation { get; set; }

    [ForeignKey("GCDeliveryLocation")]
    [InverseProperty("PatientBirthRecordGCDeliveryLocationNavigation")]
    public virtual sysGeneralCode? GCDeliveryLocationNavigation { get; set; }

    [ForeignKey("GCDeliveryMethod")]
    [InverseProperty("PatientBirthRecordGCDeliveryMethodNavigation")]
    public virtual sysGeneralCode? GCDeliveryMethodNavigation { get; set; }

    [ForeignKey("GCParamedicType")]
    [InverseProperty("PatientBirthRecordGCParamedicTypeNavigation")]
    public virtual sysGeneralCode? GCParamedicTypeNavigation { get; set; }

    [ForeignKey("GCStatusRLPerinatology")]
    [InverseProperty("PatientBirthRecordGCStatusRLPerinatologyNavigation")]
    public virtual sysGeneralCode? GCStatusRLPerinatologyNavigation { get; set; }

    [ForeignKey("MotherMedicalNo")]
    [InverseProperty("PatientBirthRecord")]
    public virtual Patient? MotherMedicalNoNavigation { get; set; }

    [ForeignKey("MotherRegistrationNo")]
    [InverseProperty("PatientBirthRecordMotherRegistrationNoNavigation")]
    public virtual Registration? MotherRegistrationNoNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientBirthRecordRegistrationNoNavigation")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientBirthRecord")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
