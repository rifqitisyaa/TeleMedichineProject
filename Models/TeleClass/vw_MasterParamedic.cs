using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterParamedic
{
    [StringLength(10)]
    [Unicode(false)]
    public string ParamedicCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ParamedicInitial { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ParamedicType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmploymentStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Religion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SpecialtyName { get; set; }

    public DateOnly? HiredDate { get; set; }

    public DateOnly? TerminatedDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TaxRegistrantNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LicenseNo { get; set; } = null!;

    public DateOnly? LicenseExpiredDate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool IsFeeUsingPercentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? FeePercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal FeeAmount { get; set; }
}
