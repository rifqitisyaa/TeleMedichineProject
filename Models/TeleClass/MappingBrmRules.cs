using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class MappingBrmRules
{
    [StringLength(512)]
    [Unicode(false)]
    public string? RulesID { get; set; }

    [Column("Rules Code")]
    [StringLength(512)]
    [Unicode(false)]
    public string? Rules_Code { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemCompileCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemID { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [Column("Rules Type")]
    [StringLength(512)]
    [Unicode(false)]
    public string? Rules_Type { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ParameterValue { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Val { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Operand { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsAdvanced { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsIndicator { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemName1 { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsNumeric { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemCompileName { get; set; }
}
