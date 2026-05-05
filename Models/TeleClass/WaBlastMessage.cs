using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class WaBlastMessage
{
    public int ID { get; set; }

    public int? TemplateId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReceivedNumber { get; set; }

    public bool? IsSendSuccess { get; set; }

    [Unicode(false)]
    public string? MessageLog { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LogUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LogDateTime { get; set; }
}
