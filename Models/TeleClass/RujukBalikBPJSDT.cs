using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ItemID")]
public partial class RujukBalikBPJSDT
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? kdObat { get; set; }

    public byte? Signa1Frequency { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Signa2Qty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal TotalQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
