using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ICDBlock
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ICDBlockID { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string ICDBlockName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCICDChapter { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ICDBlock")]
    public virtual ICollection<Diagnosis> Diagnosis { get; set; } = new List<Diagnosis>();

    [InverseProperty("ICDBlock")]
    public virtual ICollection<DiagnosisTB> DiagnosisTB { get; set; } = new List<DiagnosisTB>();

    [ForeignKey("GCICDChapter")]
    [InverseProperty("ICDBlock")]
    public virtual sysGeneralCode? GCICDChapterNavigation { get; set; }
}
