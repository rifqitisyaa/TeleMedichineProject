using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class FaskesReferralSisruteHd
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string FaskesCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaFaskes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TipeFaskes { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
