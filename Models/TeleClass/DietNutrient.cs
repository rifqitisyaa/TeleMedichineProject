using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DietNutrient
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PreparedDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DietCalories { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DietType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMilkConsumption { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTeaConsumption { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCoffeeConsumption { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCVegetarian { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StartEating { get; set; }

    [Unicode(false)]
    public string? Prohibition { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFoodTexture { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDietType { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Height { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? BMI { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPatientStatus { get; set; }

    public bool? IsFasting { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCCoffeeConsumption")]
    [InverseProperty("DietNutrientGCCoffeeConsumptionNavigation")]
    public virtual sysGeneralCode? GCCoffeeConsumptionNavigation { get; set; }

    [ForeignKey("GCDietType")]
    [InverseProperty("DietNutrientGCDietTypeNavigation")]
    public virtual sysGeneralCode? GCDietTypeNavigation { get; set; }

    [ForeignKey("GCFoodTexture")]
    [InverseProperty("DietNutrientGCFoodTextureNavigation")]
    public virtual sysGeneralCode? GCFoodTextureNavigation { get; set; }

    [ForeignKey("GCMilkConsumption")]
    [InverseProperty("DietNutrientGCMilkConsumptionNavigation")]
    public virtual sysGeneralCode? GCMilkConsumptionNavigation { get; set; }

    [ForeignKey("GCTeaConsumption")]
    [InverseProperty("DietNutrientGCTeaConsumptionNavigation")]
    public virtual sysGeneralCode? GCTeaConsumptionNavigation { get; set; }

    [ForeignKey("GCVegetarian")]
    [InverseProperty("DietNutrientGCVegetarianNavigation")]
    public virtual sysGeneralCode? GCVegetarianNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("DietNutrient")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
