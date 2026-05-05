using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class OTProgressInformation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProgressCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ProgressName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    public bool IsHeader { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OTPhase { get; set; } = null!;

    [Unicode(false)]
    public string? Reference { get; set; }

    [Unicode(false)]
    public string? Command { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<OTProgressInformation> InverseParent { get; set; } = new List<OTProgressInformation>();

    [ForeignKey("ParentID")]
    [InverseProperty("InverseParent")]
    public virtual OTProgressInformation? Parent { get; set; }
}
