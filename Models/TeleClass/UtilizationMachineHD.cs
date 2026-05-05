using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class UtilizationMachineHD
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MachineID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? MachineName { get; set; }

    public int? MachineCapacity { get; set; }

    public int? MachineLoad { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? MachineUtilization { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMachineStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MachineNote { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
