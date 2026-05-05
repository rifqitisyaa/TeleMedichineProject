using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Callibrations
{
    [StringLength(50)]
    [Unicode(false)]
    public string CallibrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CallibrationDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CallibrationMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CallibrationCompany { get; set; }

    [Unicode(false)]
    public string? Result { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CertificateNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CertificateImage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CallibrationExpiredDate { get; set; }

    public int AssetID { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("AssetID")]
    public virtual Assets Asset { get; set; } = null!;
}
