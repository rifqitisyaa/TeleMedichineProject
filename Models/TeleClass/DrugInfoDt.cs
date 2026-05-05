using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DrugInfoDt
{
    [Key]
    public int DetailId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReferenceId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SequenceNo")]
    [InverseProperty("DrugInfoDt")]
    public virtual DrugInfoHd SequenceNoNavigation { get; set; } = null!;
}
