using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _imp_mims_ItemBrand
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string BrandCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BrandName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? Manufacturer { get; set; }

    [Unicode(false)]
    public string? Indications { get; set; }

    [Unicode(false)]
    public string? Dosage { get; set; }

    [Unicode(false)]
    public string? Administration { get; set; }

    [Unicode(false)]
    public string? ContraIndications { get; set; }

    [Unicode(false)]
    public string? SpecialPrecautions { get; set; }

    [Unicode(false)]
    public string? AdverseDrugReactions { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MIMSClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ATCClassCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPregnancyCategory { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugClass { get; set; }

    public Guid? MimsReferenceID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
