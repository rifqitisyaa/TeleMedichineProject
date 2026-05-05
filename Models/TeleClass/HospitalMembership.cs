using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HospitalMembership
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? UserPassword { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ParamedicName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCParamedic { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
