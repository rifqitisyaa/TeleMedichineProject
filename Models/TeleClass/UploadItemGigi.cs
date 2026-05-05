using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class UploadItemGigi
{
    public double? ItemId { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemGroupCode { get; set; }

    [StringLength(255)]
    public string? Group { get; set; }

    [StringLength(255)]
    public string? remarks { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? INACBGTariffKategori { get; set; }

    [StringLength(255)]
    public string? IsAllowOrder { get; set; }

    [StringLength(255)]
    public string? BaseUnitCode { get; set; }

    [StringLength(255)]
    public string? BaseUnit { get; set; }

    [StringLength(255)]
    public string? PurchaseUnitCode { get; set; }

    [StringLength(255)]
    public string? Purchase_Unit { get; set; }

    [StringLength(255)]
    public string? Conversionfactor { get; set; }

    [StringLength(255)]
    public string? ABCClass { get; set; }

    [StringLength(255)]
    public string? IsControlExpired { get; set; }

    [StringLength(255)]
    public string? IsPurchaseItem { get; set; }

    [StringLength(255)]
    public string? SafetyStock { get; set; }

    [StringLength(255)]
    public string? Min_PO { get; set; }

    [StringLength(255)]
    public string? Max_PO { get; set; }

    [StringLength(255)]
    public string? Min_Gudang_A { get; set; }

    [StringLength(255)]
    public string? Max_Gudang_A { get; set; }

    [StringLength(255)]
    public string? Min_Gudang_Lain { get; set; }

    [StringLength(255)]
    public string? Max_Gudang_Lain { get; set; }

    [StringLength(255)]
    public string? BusinessPartnerID { get; set; }

    [StringLength(255)]
    public string? DefaultSupplier { get; set; }

    [Column("Purchase Price")]
    [StringLength(255)]
    public string? Purchase_Price { get; set; }

    [StringLength(255)]
    public string? Rak_gudang_pusat { get; set; }

    public double? IsConsignment { get; set; }

    [StringLength(255)]
    public string? ReceiveTolerance { get; set; }

    [StringLength(255)]
    public string? OrderPercentage { get; set; }

    [StringLength(255)]
    public string? OrderPriceTolerance { get; set; }

    [Column("MaterialCost/HPP")]
    public double? MaterialCost_HPP { get; set; }

    public double? RAWAT_JALAN { get; set; }

    public double? IGD { get; set; }

    public double? CLASS_3 { get; set; }

    public double? CLASS_2 { get; set; }

    public double? CLASS_1 { get; set; }

    public double? NON_CLASS { get; set; }

    public double? Superior { get; set; }

    public double? VIP { get; set; }

    public double? E_VIP { get; set; }

    public double? President_Suite { get; set; }
}
