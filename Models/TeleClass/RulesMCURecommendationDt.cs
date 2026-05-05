using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RulesID", "SequenceNo")]
public partial class RulesMCURecommendationDt
{
    [Key]
    public int RulesID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RecommendationCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RecommendationCode")]
    [InverseProperty("RulesMCURecommendationDt")]
    public virtual ItemCompileMCU RecommendationCodeNavigation { get; set; } = null!;

    [ForeignKey("RulesID")]
    [InverseProperty("RulesMCURecommendationDt")]
    public virtual RulesMCUHd Rules { get; set; } = null!;
}
