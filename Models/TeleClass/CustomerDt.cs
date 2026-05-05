using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Id", "SequenceNo")]
public partial class CustomerDt
{
    [Key]
    public int Id { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerType { get; set; } = null!;

    [Unicode(false)]
    public string Gift { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartEffDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndEffDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsedDate { get; set; }

    public bool? IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
