using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RLTemplateDt
{
    [Key]
    public long RowId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReportID { get; set; } = null!;

    [Unicode(false)]
    public string? Value { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Formula { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GroupFormula { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FormulaType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    public bool? IsNeedUserEntry { get; set; }

    [InverseProperty("Row")]
    public virtual ICollection<RLData> RLData { get; set; } = new List<RLData>();

    [ForeignKey("ReportID")]
    [InverseProperty("RLTemplateDt")]
    public virtual RLTemplateHd Report { get; set; } = null!;
}
