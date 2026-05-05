using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class KfaInject
{
    public int? ItemID { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ItemName1 { get; set; }

    [Column("KFA Product Kode")]
    public int? KFA_Product_Kode { get; set; }

    [Column("KFA Product Name ")]
    [StringLength(512)]
    [Unicode(false)]
    public string? KFA_Product_Name_ { get; set; }

    [Column("KFA Ingridient Kode")]
    public int? KFA_Ingridient_Kode { get; set; }

    [Column("KFA Ingridient Name")]
    [StringLength(512)]
    [Unicode(false)]
    public string? KFA_Ingridient_Name { get; set; }
}
