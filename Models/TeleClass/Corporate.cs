using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Corporate
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CorporateCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CorporateName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson2 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TaxRegistrantNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CorporateCodeNavigation")]
    public virtual ICollection<Site> Site { get; set; } = new List<Site>();
}
