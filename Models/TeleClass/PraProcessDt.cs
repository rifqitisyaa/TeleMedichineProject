using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("DocumentNo", Name = "IX_PraProcessDt")]
public partial class PraProcessDt
{
    [Key]
    public long Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCMember { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinVariablePrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxVariablePrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal NewStandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NewCustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NewPersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NewDiscountPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NewMinVariablePrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NewMaxVariablePrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NonRegularPrice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("PraProcessDt")]
    public virtual ClassCategory ClassCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("DocumentNo")]
    [InverseProperty("PraProcessDt")]
    public virtual PraProcessHd DocumentNoNavigation { get; set; } = null!;

    [ForeignKey("GCMember")]
    [InverseProperty("PraProcessDt")]
    public virtual sysGeneralCode GCMemberNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("PraProcessDt")]
    public virtual Item Item { get; set; } = null!;
}
