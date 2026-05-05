using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Table_4
{
    public int ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    public int PayerID { get; set; }

    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    public DateOnly? StartPeriodeDate { get; set; }

    public DateOnly? EndPeriodeDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Discount1Percentage { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Discount2Percentage { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
