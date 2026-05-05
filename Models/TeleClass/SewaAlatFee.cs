using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SewaAlatFee
{
    [Key]
    public int SewaAlatFeeID { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ProcessDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SewaAlatAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
