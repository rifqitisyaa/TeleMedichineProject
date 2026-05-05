using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatMedicationVariasiHd
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string MedicationCreateID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? ExtensionCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ExtensionDisplay { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CodeCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CodeDisplay { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? FormCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FormDisplay { get; set; }

    public bool IsCompound { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("MedicationCreate")]
    public virtual ICollection<SatuSehatMedicationVariasiDt> SatuSehatMedicationVariasiDt { get; set; } = new List<SatuSehatMedicationVariasiDt>();
}
