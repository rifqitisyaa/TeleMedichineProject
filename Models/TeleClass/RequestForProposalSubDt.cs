using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RFPNo", "SequenceNo")]
public partial class RequestForProposalSubDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RFPNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    public DateOnly? POReleaseDate { get; set; }

    public DateOnly? PODueDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("RequestForProposalSubDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("RequestForProposalSubDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("RFPNo")]
    [InverseProperty("RequestForProposalSubDt")]
    public virtual RequestForProposalHd RFPNoNavigation { get; set; } = null!;

    [InverseProperty("RequestForProposalSubDt")]
    public virtual ICollection<RequestForProposalDt> RequestForProposalDt { get; set; } = new List<RequestForProposalDt>();
}
