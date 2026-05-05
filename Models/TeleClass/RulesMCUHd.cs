using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RulesMCUHd
{
    [Key]
    public int RulesID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ProblemCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ProblemCode")]
    [InverseProperty("RulesMCUHd")]
    public virtual ItemCompileMCU ProblemCodeNavigation { get; set; } = null!;

    [InverseProperty("Rules")]
    public virtual ICollection<RulesMCURecommendationDt> RulesMCURecommendationDt { get; set; } = new List<RulesMCURecommendationDt>();

    [InverseProperty("Rules")]
    public virtual ICollection<UnfitRulesMCUCorporate> UnfitRulesMCUCorporate { get; set; } = new List<UnfitRulesMCUCorporate>();
}
