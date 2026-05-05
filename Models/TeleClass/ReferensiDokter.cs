using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ParamedicID")]
public partial class ReferensiDokter
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ParamedicID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ReferensiParamedicCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ReferensiParamedicName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
