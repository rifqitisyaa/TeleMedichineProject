using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatInstruksiMedikDanKeperawatanPasien
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string InstruksiMedikKeperawatanID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? EncounterIHSNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Unicode(false)]
    public string? SnomedCode { get; set; }

    [Unicode(false)]
    public string? SnomedName { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
