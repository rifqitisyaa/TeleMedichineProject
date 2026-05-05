using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class VAPAdministration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TanggalPemasangan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLepas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ScoreCpis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DurasiPemakaianVentilator { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VentBundleChecklist { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VAP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keluhan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
