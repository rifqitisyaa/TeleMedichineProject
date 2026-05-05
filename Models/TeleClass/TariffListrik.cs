using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TariffListrik
{
    [Key]
    public int TariffID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorIDPelanggan { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? LwbpPrice { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Wbp1Price { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? wbp2Price { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? KvarhPrice { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? FactorValue { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
