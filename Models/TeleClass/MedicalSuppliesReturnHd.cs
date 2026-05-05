using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MedicalSuppliesReturnHd
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MedicalSuppliesReturnNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly MedicalSuppliesReturnDate { get; set; }

    public int ServiceUnitID { get; set; }

    public int LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMedicalSuppliesReturnReason { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
