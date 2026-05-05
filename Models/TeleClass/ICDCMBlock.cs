using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ICDCMBlock
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ICDCMBlockID { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string ICDCMBlockName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }

    [InverseProperty("ICDCMBlock")]
    public virtual ICollection<Procedures> Procedures { get; set; } = new List<Procedures>();
}
