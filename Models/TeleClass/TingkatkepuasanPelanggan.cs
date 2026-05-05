using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TingkatkepuasanPelanggan
{
    [Key]
    public long Id { get; set; }

    public int TemplateId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InputDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ResponseScore { get; set; } = null!;

    [Unicode(false)]
    public string ResponseText { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("TingkatkepuasanPelanggan")]
    public virtual TemplateTingkatKepuasanPelanggan Template { get; set; } = null!;
}
