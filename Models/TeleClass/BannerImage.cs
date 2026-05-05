using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BannerImage
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BannerImageCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BannerImageName { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
