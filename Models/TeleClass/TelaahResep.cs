using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TelaahResep
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    public bool? Hamil { get; set; }

    public bool? Menyusui { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DitelaahOlehResep { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DitelaahOlehResepDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DiambilkanOleh { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DiambilkanOlehDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DikemasOleh { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DikemasOlehDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DitelaahOlehObat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DitelaahOlehObatDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DiserahkanOleh { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DiserahkanOlehDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PerubahanResepTertulis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PerubahanResepMenjadi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PetugasFarmasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisetetujuiOleh { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
