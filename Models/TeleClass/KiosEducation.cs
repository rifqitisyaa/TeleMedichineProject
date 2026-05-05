using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class KiosEducation
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Unicode(false)]
    public string EducationDescription { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ThumbnailImageUrl { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string FileUrl { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
