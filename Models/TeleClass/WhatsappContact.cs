using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WhatsappContact
{
    [Key]
    public int ContactId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? GroupName { get; set; }

    [Unicode(false)]
    public string? Tags { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastSend { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
