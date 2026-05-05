using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimPatient
{
    [Key]
    public int PatientID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    public int SexID { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? BloodTypeRhesus { get; set; }

    public int? EducationID { get; set; }

    public int? MaritalStatusID { get; set; }

    public int? NationalityID { get; set; }

    public int? OccupationID { get; set; }

    public int? RaceID { get; set; }

    public int? ReligionID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AddressLine1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AddressLine2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Province { get; set; }

    public int? DateOfDeathID { get; set; }

    public int? TimeOfDeathID { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [ForeignKey("DateOfDeathID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimDate? DateOfDeath { get; set; }

    [ForeignKey("EducationID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimEducation? Education { get; set; }

    [ForeignKey("MaritalStatusID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimMaritalStatus? MaritalStatus { get; set; }

    [ForeignKey("NationalityID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimNationality? Nationality { get; set; }

    [ForeignKey("OccupationID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimOccupation? Occupation { get; set; }

    [ForeignKey("RaceID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimRace? Race { get; set; }

    [ForeignKey("ReligionID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimReligion? Religion { get; set; }

    [ForeignKey("SexID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimSex Sex { get; set; } = null!;

    [ForeignKey("TimeOfDeathID")]
    [InverseProperty("DW_DimPatient")]
    public virtual DW_DimTime? TimeOfDeath { get; set; }
}
