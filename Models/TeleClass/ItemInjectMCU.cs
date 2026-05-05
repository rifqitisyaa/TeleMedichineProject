using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ItemInjectMCU
{
    public int? ItemID { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    public int? RulesID { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Opperand { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ParameterValue { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Connector { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ProblemCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? RecommendationCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Recomendation { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Problem { get; set; }
}
