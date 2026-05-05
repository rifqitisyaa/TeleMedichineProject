using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessParterID", "ItemIdHospital", "ItemCodeCorporate")]
public partial class CorporateItem
{
    [Key]
    public int BusinessParterID { get; set; }

    [Key]
    public int ItemIdHospital { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCodeCorporate { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ItemNameCorporate { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessParterID")]
    [InverseProperty("CorporateItem")]
    public virtual BusinessPartner BusinessParter { get; set; } = null!;

    [ForeignKey("ItemIdHospital")]
    [InverseProperty("CorporateItem")]
    public virtual Item ItemIdHospitalNavigation { get; set; } = null!;
}
