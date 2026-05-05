using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ClassCode", "SequenceNo")]
public partial class AssetClassDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string BookCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string BookSequenceNo { get; set; } = null!;

    public int MethodID { get; set; }

    public int ServiceLife { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BookCode, BookSequenceNo")]
    [InverseProperty("AssetClassDt")]
    public virtual AssetBook AssetBook { get; set; } = null!;

    [ForeignKey("ClassCode")]
    [InverseProperty("AssetClassDt")]
    public virtual AssetClassHd ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("MethodID")]
    [InverseProperty("AssetClassDt")]
    public virtual AssetDepreciationMethod Method { get; set; } = null!;
}
