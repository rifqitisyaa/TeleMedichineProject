using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class InfeksiPPI
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int SequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCInfeksiPPI { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
