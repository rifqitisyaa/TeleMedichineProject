using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class InstrumentalActivity
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
    public string? MenggunakanTeleponValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BerbelanjaValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MenyiapkanMakananValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MengurusRumahValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LaundryValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ModelTransportasiValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggungJawabValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MengaturKeuanganValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ActivityScore { get; set; }

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
