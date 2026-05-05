using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpObatBaru0802
{
    [StringLength(255)]
    public string? ItemId { get; set; }

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
    public string? BaseUnitCode { get; set; }

    [StringLength(255)]
    public string? BaseUnit { get; set; }

    public double? Dosis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DosisUnit { get; set; }

    [StringLength(255)]
    public string? SatuanDosis { get; set; }

    [StringLength(255)]
    public string? PurchaseUnitCode { get; set; }

    [StringLength(255)]
    public string? Purchase_Unit { get; set; }

    [StringLength(255)]
    public string? ConversionFactor { get; set; }

    [StringLength(255)]
    public string? IsPurchaseItem { get; set; }

    [StringLength(255)]
    public string? ABCClass { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DrugForm { get; set; }

    [StringLength(255)]
    public string? Bentuk_Sediaan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRoute { get; set; }

    [StringLength(255)]
    public string? RutePemberian { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ConsumeUnitCode { get; set; }

    [StringLength(255)]
    public string? DefaultConsumeUnit { get; set; }

    [StringLength(255)]
    public string? Golongan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GCDrugType { get; set; }

    [Column("ObatLuar/Dalam")]
    [StringLength(255)]
    public string? ObatLuar_Dalam { get; set; }

    public double? Min_PO { get; set; }

    [StringLength(255)]
    public string? Max_PO { get; set; }

    [StringLength(255)]
    public string? SafetyStock { get; set; }

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

    [StringLength(255)]
    public string? OrderPercentage { get; set; }

    [StringLength(255)]
    public string? ReceivingPercentage { get; set; }

    [StringLength(255)]
    public string? OrderPriceTolerance { get; set; }

    [StringLength(255)]
    public string? RackPosition { get; set; }

    [Column("Purchase Price")]
    [StringLength(255)]
    public string? Purchase_Price { get; set; }

    public double? IsFormularium { get; set; }

    public double? IsAllowRoundUp { get; set; }

    public double? IsGenericDrug { get; set; }

    public double? IsOOT { get; set; }

    public double? IsNarkotika { get; set; }

    public double? IsPsikotropika { get; set; }

    public double? IsAntibiotik { get; set; }

    public double? IsHighAlert { get; set; }

    [StringLength(255)]
    public string? IsConsignment { get; set; }

    [StringLength(255)]
    public string? IsControlExpired { get; set; }

    [StringLength(255)]
    public string? ATCClassCode { get; set; }

    [StringLength(255)]
    public string? ATCClassName { get; set; }

    [Column("MaterialCost/HPP")]
    [StringLength(255)]
    public string? MaterialCost_HPP { get; set; }

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
