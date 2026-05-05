using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("VaccinationCode", "ItemID")]
public partial class ItemVaccination
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string VaccinationCode { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemVaccination")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("VaccinationCode")]
    [InverseProperty("ItemVaccination")]
    public virtual Vaccination VaccinationCodeNavigation { get; set; } = null!;
}
