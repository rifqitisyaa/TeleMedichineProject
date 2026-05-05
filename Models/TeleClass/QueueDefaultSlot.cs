using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class QueueDefaultSlot
{
    [StringLength(50)]
    [Unicode(false)]
    public string? SlotQueueNo { get; set; }
}
