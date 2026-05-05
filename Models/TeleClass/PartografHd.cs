using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PartografHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PartografDateTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string PartografTime { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MulaiMules { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string KetubanPecah { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Garivad { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Para { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Abortus { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
