using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BackupQueuingReference
{
    public int QueuingId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime QueuingDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IpAddress { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? QueuingNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? QueuingType { get; set; }

    public bool? CallNo { get; set; }

    public bool? IsDisplay { get; set; }

    public bool? IsAttend { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JamPanggil { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
