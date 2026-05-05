using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DocumentNo", "ContractNo")]
public partial class CustomerContractConsidalitionDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ContractNo { get; set; } = null!;

    public bool IsDelete { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdateBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdateDateTime { get; set; }
}
