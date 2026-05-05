using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimParamedic
{
    [Key]
    public int ParamedicID { get; set; }

    public int ParamedicIDOri { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ParamedicCode { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    public int? SexID { get; set; }

    public int? ParamedicTypeID { get; set; }

    public int? EmploymentStatusID { get; set; }

    public int? NationalityID { get; set; }

    public int? SpecialtyID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [InverseProperty("Paramedic")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [ForeignKey("EmploymentStatusID")]
    [InverseProperty("DW_DimParamedic")]
    public virtual DW_DimEmploymentStatus? EmploymentStatus { get; set; }

    [ForeignKey("NationalityID")]
    [InverseProperty("DW_DimParamedic")]
    public virtual DW_DimNationality? Nationality { get; set; }

    [ForeignKey("ParamedicTypeID")]
    [InverseProperty("DW_DimParamedic")]
    public virtual DW_DimParamedicType? ParamedicType { get; set; }

    [ForeignKey("SexID")]
    [InverseProperty("DW_DimParamedic")]
    public virtual DW_DimSex? Sex { get; set; }

    [ForeignKey("SpecialtyID")]
    [InverseProperty("DW_DimParamedic")]
    public virtual DW_DimSpecialty? Specialty { get; set; }
}
