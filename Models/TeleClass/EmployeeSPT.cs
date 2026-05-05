using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EmployeeId", "Year", "IdNo")]
public partial class EmployeeSPT
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    public int Year { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string IdNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Category { get; set; }

    [Unicode(false)]
    public string? Label { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Value { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeSPT")]
    public virtual Employee Employee { get; set; } = null!;
}
