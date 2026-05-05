using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class KuisionerMentalPegawai
{
    [Key]
    public int QuestionID { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string DetailSequence { get; set; } = null!;

    [Unicode(false)]
    public string? Question { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? QuestionType { get; set; }

    [Unicode(false)]
    public string? QuestionTypeName { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
