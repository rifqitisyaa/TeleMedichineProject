using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WhatsappLog
{
    [Key]
    public int ID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LogKey { get; set; }

    public int? InstanceId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JobId { get; set; }

    public int? ContactId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CampaignName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CampaignCreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CampaignScheduledAt { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CampaignStatus { get; set; }

    [Unicode(false)]
    public string? MessageText { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MessageCreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MessageStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SentTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DeliveryStatus { get; set; }

    [Unicode(false)]
    public string? ResponseText { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? ContactPhoneNumber { get; set; }
}
