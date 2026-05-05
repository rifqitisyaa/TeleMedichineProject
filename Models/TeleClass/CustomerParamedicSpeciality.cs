using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ParamedicID", "SpecialtyCode")]
public partial class CustomerParamedicSpeciality
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ParamedicID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerParamedicCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CustomerParamedicName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
