using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class DrugReturnNHTemp
{
    [StringLength(255)]
    public string? ItemID { get; set; }

    [StringLength(255)]
    public string? StandardPrice { get; set; }

    [StringLength(255)]
    public string? CustomerPrice { get; set; }

    [StringLength(255)]
    public string? CostPrice { get; set; }

    [StringLength(255)]
    public string? PersonalPrice { get; set; }

    [StringLength(255)]
    public string? DiscountPrice { get; set; }

    [StringLength(255)]
    public string? TotalPersonal { get; set; }

    [StringLength(255)]
    public string? TotalCustomer { get; set; }

    [StringLength(255)]
    public string? DrugDispensingNo { get; set; }

    [StringLength(255)]
    public string? SequenceNo { get; set; }

    [StringLength(255)]
    public string? ItemName1 { get; set; }

    [StringLength(255)]
    public string? TakenQty { get; set; }

    [StringLength(255)]
    public string? ItemUnitName { get; set; }

    [StringLength(255)]
    public string? ItemUnitCode { get; set; }

    [StringLength(255)]
    public string? ReturnedQty { get; set; }

    [StringLength(255)]
    public string? RemainingQty { get; set; }

    [StringLength(255)]
    public string? ReturnQty { get; set; }

    [StringLength(255)]
    public string? key { get; set; }
}
