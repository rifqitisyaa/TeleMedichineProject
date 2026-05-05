using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinnessPartnerID", "GCProvinsiCode")]
public partial class CustomerProvinsi
{
    [Key]
    public int BusinnessPartnerID { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCProvinsiCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CustProvCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CustProvName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
