using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MasterRevenueSharing
{
    [Key]
    public long Id { get; set; }

    public int ParamedicID { get; set; }

    public bool? IsAllItem { get; set; }

    public int? ItemID { get; set; }

    public bool? IsAllCorporate { get; set; }

    public int? BusinessPartnerId { get; set; }

    public bool? IsAllClass { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    public bool? IsByPercentage { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PercentageAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? FixedAmount { get; set; }

    public bool? IsCustom { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomKeyword { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
