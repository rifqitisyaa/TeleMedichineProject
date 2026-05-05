using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpUploud
{
    public double? ParamedicID { get; set; }

    [Column("Paramedic Name")]
    [StringLength(255)]
    public string? Paramedic_Name { get; set; }

    public double? IsAllItem { get; set; }

    public double? ItemID { get; set; }

    [Column("Nama Item")]
    [StringLength(255)]
    public string? Nama_Item { get; set; }

    public double? IsAllCorporate { get; set; }

    [StringLength(255)]
    public string? BusinessPartnerId { get; set; }

    public double? IsAllClass { get; set; }

    public double? ClassCode { get; set; }

    public double? IsByPercentage { get; set; }

    public double? PercentageAmount { get; set; }

    public double? FixedAmount { get; set; }

    public double? IsCustom { get; set; }

    [StringLength(255)]
    public string? CustomKeyword { get; set; }

    [StringLength(255)]
    public string? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
