using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SendToWaDataGigi
{
    [StringLength(30)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [Unicode(false)]
    public string? MessageSend { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RecipientNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SendBy { get; set; }

    public bool? IsSend { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
