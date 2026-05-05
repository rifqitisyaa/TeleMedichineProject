using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class IadpAdministrationRev
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
    public DateTime? AdministrationDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusPemasangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoCvc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DurasiPemakaianCVC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LokasiPemasanganCVC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisCVC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemPencegahanBSI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GejalaBSI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IADP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
