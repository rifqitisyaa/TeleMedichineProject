using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysSite
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SiteName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CorporateCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSiteGroup { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string LicenseNo { get; set; } = null!;

    /// <summary>
    /// Greenwich Mean Time
    /// </summary>
    public int Gmt { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
