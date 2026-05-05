using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MasterEmployee
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MasterEmployeeID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmployeeName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemGroupName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
