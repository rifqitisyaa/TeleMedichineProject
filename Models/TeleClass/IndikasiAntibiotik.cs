using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JoborderNo", "SequenceNo")]
public partial class IndikasiAntibiotik
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string JoborderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public bool? IsProfilaksis { get; set; }

    public bool? IsEmpirik { get; set; }

    public bool? IsDefinitif { get; set; }

    public bool? IsNotAntibiotik { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
