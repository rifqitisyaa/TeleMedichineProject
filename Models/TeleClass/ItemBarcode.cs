using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemBarcode
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BarcodeCode { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiredDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ConvertionQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
