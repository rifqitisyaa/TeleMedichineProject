using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AntrianPanggilRegistrasi
{
    [Key]
    public long ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IpAddress { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? QueueNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
