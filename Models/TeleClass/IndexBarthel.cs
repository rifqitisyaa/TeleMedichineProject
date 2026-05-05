using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class IndexBarthel
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
    public string? MakanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MandiValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MengurusDiriValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BerpakaianValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PencernaanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KandungKemihValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenggunaanToiletValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BerpindahTempatValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MobilitasValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggaValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IndexBarthelValue { get; set; }

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
