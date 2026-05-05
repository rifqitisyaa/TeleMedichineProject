using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MachineHD
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MachineCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MachineName { get; set; } = null!;

    public int? MachineCapacity { get; set; }

    public int? MachineMaxLoad { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MachineWorkShift { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMachineStatus { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
