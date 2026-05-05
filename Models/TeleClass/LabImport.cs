using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class LabImport
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
    public string? ItemName1 { get; set; }

    [StringLength(255)]
    public string? NamaInternasional { get; set; }

    [StringLength(255)]
    public string? Remarks { get; set; }

    [StringLength(255)]
    public string? IsHeader { get; set; }

    [StringLength(255)]
    public string? Position { get; set; }

    [StringLength(255)]
    public string? Lv { get; set; }

    [StringLength(255)]
    public string? Bold { get; set; }

    [StringLength(255)]
    public string? ParentCode { get; set; }

    [StringLength(255)]
    public string? ParentID { get; set; }

    [StringLength(255)]
    public string? IsAllowOrder { get; set; }

    [StringLength(255)]
    public string? BaseUnitCode { get; set; }

    [StringLength(255)]
    public string? ItemUnitName { get; set; }

    [StringLength(255)]
    public string? RAWAT_JALAN { get; set; }

    [StringLength(255)]
    public string? IGD { get; set; }

    [StringLength(255)]
    public string? CLASS_3 { get; set; }

    [StringLength(255)]
    public string? CLASS_2 { get; set; }

    [StringLength(255)]
    public string? CLASS_1 { get; set; }

    [StringLength(255)]
    public string? NON_CLASS { get; set; }

    [StringLength(255)]
    public string? Superior { get; set; }

    [StringLength(255)]
    public string? VIP { get; set; }

    [StringLength(255)]
    public string? E_VIP { get; set; }

    [StringLength(255)]
    public string? President_Suite { get; set; }

    [StringLength(255)]
    public string? LaborCost { get; set; }

    [StringLength(255)]
    public string? OverheadCost { get; set; }

    [StringLength(255)]
    public string? SubconCost { get; set; }

    [StringLength(255)]
    public string? VariableCost { get; set; }

    [StringLength(255)]
    public string? Price { get; set; }

    [StringLength(255)]
    public string? IsAllowCito { get; set; }

    [StringLength(255)]
    public string? IsAllowVariable { get; set; }

    [StringLength(255)]
    public string? F34 { get; set; }

    [StringLength(255)]
    public string? F35 { get; set; }
}
