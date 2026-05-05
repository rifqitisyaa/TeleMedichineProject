using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateTariffHd
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    public int? BusinessPartnerID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalPrice { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("TemplateTariffHd")]
    public virtual BusinessPartner? BusinessPartner { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("TemplateTariffHd")]
    public virtual Class? ClassCodeNavigation { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<TemplateTariffDt> TemplateTariffDt { get; set; } = new List<TemplateTariffDt>();
}
