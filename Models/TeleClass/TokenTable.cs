using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TokenTable
{
    [Key]
    [StringLength(51)]
    [Unicode(false)]
    public string TokenCode { get; set; } = null!;

    [StringLength(101)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedTokenDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiredTokenDateTime { get; set; }
}
