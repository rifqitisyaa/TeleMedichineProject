using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ParamedicCertificate
{
    [Key]
    public int Id { get; set; }

    public int ParamedicId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string FileName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DocumentName { get; set; } = null!;

    public bool? IsShow { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicId")]
    [InverseProperty("ParamedicCertificate")]
    public virtual Paramedic Paramedic { get; set; } = null!;
}
