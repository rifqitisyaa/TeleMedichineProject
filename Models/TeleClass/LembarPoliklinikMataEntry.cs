using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class LembarPoliklinikMataEntry
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateAtas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Anamnesa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Palp1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Palp2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Conj1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Conj2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cornea1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cornea2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Coa1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Coa2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Iris1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Iris2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pupil1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pupil2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Lensa1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Lensa2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Vitre1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Vitre2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Fundus1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Fundus2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VisusOD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VisusOS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KoreksiOD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KoreksiOS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Add1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Add2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KacaOD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KacaOS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TonoOD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TonoOS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Laboratorium { get; set; }

    [Unicode(false)]
    public string? Diagnosa { get; set; }

    [Unicode(false)]
    public string? Terapi { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
