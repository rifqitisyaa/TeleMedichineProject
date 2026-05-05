using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SalaryComponent
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SalaryCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SalaryName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string SalaryType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCSalaryGroup { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCSalaryComponentTax { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCOccurs { get; set; } = null!;

    public bool IsUsedFormula { get; set; }

    [Unicode(false)]
    public string? FormulaDescription { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? FixAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartEffectiveDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndEffectiveDateTime { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? StructureNo { get; set; }

    public bool? IsUsedBySystem { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCOccurs")]
    [InverseProperty("SalaryComponentGCOccursNavigation")]
    public virtual sysGeneralCode GCOccursNavigation { get; set; } = null!;

    [ForeignKey("GCSalaryComponentTax")]
    [InverseProperty("SalaryComponentGCSalaryComponentTaxNavigation")]
    public virtual sysGeneralCode GCSalaryComponentTaxNavigation { get; set; } = null!;

    [ForeignKey("GCSalaryGroup")]
    [InverseProperty("SalaryComponentGCSalaryGroupNavigation")]
    public virtual sysGeneralCode GCSalaryGroupNavigation { get; set; } = null!;

    [InverseProperty("SalaryCodeNavigation")]
    public virtual ICollection<PayrollProcessDt> PayrollProcessDt { get; set; } = new List<PayrollProcessDt>();

    [InverseProperty("SalaryCodeNavigation")]
    public virtual ICollection<SalaryComponentEmployee> SalaryComponentEmployee { get; set; } = new List<SalaryComponentEmployee>();
}
