using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TransactionNonCPOEServiceUnit
{
    [Key]
    public int ID { get; set; }

    public int ServiceUnitID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("TransactionNonCPOEServiceUnit")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
