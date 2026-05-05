using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RulesID", "SequenceNo")]
public partial class RulesMCUParameterDt
{
    [Key]
    public int RulesID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOperand { get; set; }

    [Unicode(false)]
    public string ParameterValue { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCConnector { get; set; } = null!;

    public bool IsAdvanced { get; set; }

    [Unicode(false)]
    public string? AdvancedCommand { get; set; }

    public bool? IsNumeric { get; set; }

    public bool? IsIndicator { get; set; }

    [Unicode(false)]
    public string DescriptionName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
