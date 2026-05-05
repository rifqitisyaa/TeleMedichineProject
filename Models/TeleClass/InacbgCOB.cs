using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class InacbgCOB
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string CustomerCOBCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerCOBName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
