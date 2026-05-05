using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ServiceUnitCode", "SpecialtyCode")]
public partial class ReferensiPoli
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ReferensiServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ReferensiServiceUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferensiSubSpecialistCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferensiSubSpecialistName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
