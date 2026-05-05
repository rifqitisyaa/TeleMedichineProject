using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class EffectiveCommunicationHd2
{
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int? Messenger { get; set; }

    public int? MessageRecipient { get; set; }

    [Unicode(false)]
    public string? MessageSend { get; set; }

    [Unicode(false)]
    public string? MessageReceived { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MessageDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Time { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
