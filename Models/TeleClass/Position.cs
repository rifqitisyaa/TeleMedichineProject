using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Position
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string PositionCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PositionName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentPositionCode { get; set; }

    public int PositionLevel { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GroupCode { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PositionScore { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PositionScore2 { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PositionPajak { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();

    [InverseProperty("PositionCodeFromNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryPositionCodeFromNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("PositionCodeToNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryPositionCodeToNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("ParentPositionCodeNavigation")]
    public virtual ICollection<Position> InverseParentPositionCodeNavigation { get; set; } = new List<Position>();

    [ForeignKey("ParentPositionCode")]
    [InverseProperty("InverseParentPositionCodeNavigation")]
    public virtual Position? ParentPositionCodeNavigation { get; set; }
}
