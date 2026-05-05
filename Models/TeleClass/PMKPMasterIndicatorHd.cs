using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PMKPMasterIndicatorHd
{
    [Key]
    public int MasterIndicatorID { get; set; }

    public int Year { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCGroupIndicator { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }
}
