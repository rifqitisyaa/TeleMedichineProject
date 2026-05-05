using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QueuingJKN
{
    [Key]
    public long ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? QueueNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorRujukan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KodeBooking { get; set; }

    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? QueueingDatetime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ServiceUnit { get; set; }

    public long? EstimateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckInDatetime { get; set; }

    public bool? IsAttend { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
