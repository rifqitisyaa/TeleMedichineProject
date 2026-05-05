using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateTingkatKepuasanPelanggan
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string QuestionCode { get; set; } = null!;

    [Unicode(false)]
    public string QuestionText { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Template")]
    public virtual ICollection<TingkatkepuasanPelanggan> TingkatkepuasanPelanggan { get; set; } = new List<TingkatkepuasanPelanggan>();
}
