using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "MedicalNo", "SequenceNo")]
public partial class MonitoringStatusFisiologisDt
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaObat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Dosis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Waktu { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tensi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nadi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
