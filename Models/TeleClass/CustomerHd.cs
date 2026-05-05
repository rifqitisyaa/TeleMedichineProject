using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CustomerHd
{
    [Key]
    public int Id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MRNPatient { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MRNRecommendedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CGCDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ConfirmBy { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
