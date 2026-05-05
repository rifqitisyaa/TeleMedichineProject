using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientVaccination
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string VaccinationTypeCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? RegistrationSequenceNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? RegistrationDetailSubNo { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    public DateOnly VaccinationDate { get; set; }

    public int? ItemID { get; set; }

    public bool IsInternal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("PatientVaccination")]
    public virtual Item? Item { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientVaccination")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("VaccinationTypeCode")]
    [InverseProperty("PatientVaccination")]
    public virtual VaccinationType VaccinationTypeCodeNavigation { get; set; } = null!;
}
