using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class ModifikasiIndexBarthel
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RangsangBabValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RangsangBakValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MembersihkanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenggunaanWcValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MakanMinumValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BergerakValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BerjalanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BerpakaianValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NaikTurunValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MandiValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ModifikasiValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
