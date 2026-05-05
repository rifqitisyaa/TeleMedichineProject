using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PTKPStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string StatusName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PTKPAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PtkpStatus")]
    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();
}
