using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MultiPayerAuthorized
{
    [Key]
    public long Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int BussinessPartnerId { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? AuthorizedNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AuthorizedAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public bool IsPending { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PendingReason { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PendingBy { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BussinessPartnerId")]
    [InverseProperty("MultiPayerAuthorized")]
    public virtual BusinessPartner BussinessPartner { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("MultiPayerAuthorized")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
