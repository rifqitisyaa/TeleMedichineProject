using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmbalaceHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string EmbalaceID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string EmbalaceName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCEmbalaceLabel { get; set; } = null!;

    public int? ItemID { get; set; }

    public bool IsUsingRangePricing { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Embalace")]
    public virtual ICollection<CompoundTemplateHd> CompoundTemplateHd { get; set; } = new List<CompoundTemplateHd>();

    [InverseProperty("Embalace")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDt { get; set; } = new List<DrugDispensingDt>();

    [InverseProperty("Embalace")]
    public virtual ICollection<EmbalaceDt> EmbalaceDt { get; set; } = new List<EmbalaceDt>();

    [ForeignKey("GCEmbalaceLabel")]
    [InverseProperty("EmbalaceHd")]
    public virtual sysGeneralCode GCEmbalaceLabelNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("EmbalaceHd")]
    public virtual Item? Item { get; set; }

    [InverseProperty("Embalace")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedication { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("Embalace")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDt { get; set; } = new List<PrescriptionTemplateDt>();
}
