using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MCUHealthItemGroup
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemName2 { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ParentID { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParentID")]
    [InverseProperty("MCUHealthItemGroup")]
    public virtual sysGeneralCode Parent { get; set; } = null!;
}
