using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MasterIndicatorID", "SequenceNo")]
public partial class PMKPMasterIndicatorDt
{
    [Key]
    public int MasterIndicatorID { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RealisasiID { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
