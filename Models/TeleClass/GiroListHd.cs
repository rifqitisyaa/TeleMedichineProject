using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class GiroListHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransNo { get; set; } = null!;

    public DateOnly? TransDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    public int? BankID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BGType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCode { get; set; }

    [StringLength(20)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
