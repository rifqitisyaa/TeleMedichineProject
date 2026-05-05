using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class ICPenundaanPelayanan
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTimeForm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alasan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alternatif { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LamaPenundaan { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Pemberi { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Penerima { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
