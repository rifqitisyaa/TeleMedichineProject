using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class GiroReplacement
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BGNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BGNoReplacement { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TransNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? TransNoReplacement { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BGDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BGDateReplacement { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
