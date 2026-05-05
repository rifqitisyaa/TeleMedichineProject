using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TemplateID", "SequenceNo")]
public partial class PhysicianBillingTemplateDt
{
    [Key]
    public int TemplateID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal DefaultQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("TemplateID")]
    [InverseProperty("PhysicianBillingTemplateDt")]
    public virtual PhysicianBillingTemplateHd Template { get; set; } = null!;
}
