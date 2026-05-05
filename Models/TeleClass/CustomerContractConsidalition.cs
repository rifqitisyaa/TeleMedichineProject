using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CustomerContractConsidalition
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ContractNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int BussinesPatnerID { get; set; }

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    [Unicode(false)]
    public string ContractSummary { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string HospitalSigned { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CorporateSigned { get; set; } = null!;

    public bool IsDelete { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdateBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdateDateTime { get; set; }
}
