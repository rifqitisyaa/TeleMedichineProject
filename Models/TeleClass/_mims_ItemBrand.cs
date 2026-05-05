using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _mims_ItemBrand
{
    [Key]
    public Guid ReferenceID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BrandName { get; set; } = null!;

    [StringLength(100)]
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

    [StringLength(200)]
    [Unicode(false)]
    public string? PregnancyCategory { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugClass { get; set; }
}
