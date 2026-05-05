using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiklusId", "SequenceNo")]
public partial class SiklusMenuDt
{
    [Key]
    public int SiklusId { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCategory { get; set; } = null!;

    public int MenuDietId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GroupCategory { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDietType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFoodTexture { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [ForeignKey("GCCategory")]
    [InverseProperty("SiklusMenuDt")]
    public virtual sysGeneralCode GCCategoryNavigation { get; set; } = null!;

    [ForeignKey("MenuDietId")]
    [InverseProperty("SiklusMenuDt")]
    public virtual MenuDiet MenuDiet { get; set; } = null!;

    [ForeignKey("SiklusId")]
    [InverseProperty("SiklusMenuDt")]
    public virtual SiklusMenuHd Siklus { get; set; } = null!;
}
