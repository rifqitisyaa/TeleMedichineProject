using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HistoryHD
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string JoborderNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OldMedicalNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ResultDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Payer { get; set; }

    public bool IsReceived { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
