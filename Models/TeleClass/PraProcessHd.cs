using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PraProcessHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocumentDate { get; set; }

    public byte RevisionNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Destination { get; set; }

    public int? BusinessPartnerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndingDate { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsNonRegularTariff { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CalculateType { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerId")]
    [InverseProperty("PraProcessHd")]
    public virtual Customer? BusinessPartner { get; set; }

    [InverseProperty("DocumentNoNavigation")]
    public virtual ICollection<PraProcessDt> PraProcessDt { get; set; } = new List<PraProcessDt>();
}
