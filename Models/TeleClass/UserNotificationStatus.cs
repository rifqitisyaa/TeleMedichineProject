using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class UserNotificationStatus
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    public bool? IsHasNotification { get; set; }
}
