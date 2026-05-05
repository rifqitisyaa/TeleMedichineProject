using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class CommunityPatient
{
    [Key]
    public int Id { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string CommunityName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Pic { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
