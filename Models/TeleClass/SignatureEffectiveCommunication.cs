using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SignatureEffectiveCommunication
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Column(TypeName = "image")]
    public byte[]? SignatureMessenger { get; set; }

    [Column(TypeName = "image")]
    public byte[]? SignatureRecipient { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
