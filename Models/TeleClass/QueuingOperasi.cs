using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QueuingOperasi
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string QueueNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CardNO { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime QueueingDatetime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CustomerServiceUnit { get; set; } = null!;

    [Unicode(false)]
    public string CustomerServiceUnitName { get; set; } = null!;

    [Unicode(false)]
    public string JenisTindakan { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? SurgeryDatetime { get; set; }

    public bool? IsTerlaksana { get; set; }

    public bool IsApproved { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDatetime { get; set; }
}
