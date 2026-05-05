using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SpecialtyImage
{
    [StringLength(50)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    public DateOnly LastUpdatedDateTime { get; set; }
}
