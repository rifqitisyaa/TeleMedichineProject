using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ParamedicID")]
public partial class CustomerParamedic
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ParamedicID { get; set; }

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

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerParamedic")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("CustomerParamedic")]
    public virtual Paramedic Paramedic { get; set; } = null!;
}
