using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitID", "HostIPAddress")]
public partial class PatientMonitoringIPAddress
{
    [Key]
    public int ServiceUnitID { get; set; }

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string HostIPAddress { get; set; } = null!;

    public int PageNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
