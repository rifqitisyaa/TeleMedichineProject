using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EmployeeId", "SequenceNo")]
public partial class WorkOffPermission
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime WorkOffDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WorkOffDateEnd { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShiftCode { get; set; } = null!;

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("WorkOffPermission")]
    public virtual Employee Employee { get; set; } = null!;
}
