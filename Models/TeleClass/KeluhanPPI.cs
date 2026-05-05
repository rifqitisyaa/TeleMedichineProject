using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "GCKeluhan")]
public partial class KeluhanPPI
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int SequenceNo { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCKeluhan { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("KeluhanPPI")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
