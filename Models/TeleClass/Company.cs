using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Company
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CompanyCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CompanyName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? TaxRegistrationNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TaxName { get; set; }

    [Unicode(false)]
    public string? Visi { get; set; }

    [Unicode(false)]
    public string? Misi { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CompanyCodeNavigation")]
    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();
}
