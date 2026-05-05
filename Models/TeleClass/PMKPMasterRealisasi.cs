using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PMKPMasterRealisasi
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string IndicatorCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCNominatorName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCDominatorName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
