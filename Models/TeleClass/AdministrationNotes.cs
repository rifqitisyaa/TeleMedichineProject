using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AdministrationNotes
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AdministrationNotesNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Unicode(false)]
    public string Notes { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PrepareBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PreparedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    public bool? IsSent { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("AdministrationNotes")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AdministrationNotes")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
