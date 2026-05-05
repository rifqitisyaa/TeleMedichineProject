using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterSite
{
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SiteName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    public int? Gmt { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TaxRegistrantNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }
}
