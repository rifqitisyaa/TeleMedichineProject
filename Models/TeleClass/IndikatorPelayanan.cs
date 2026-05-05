using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IndikatorPelayanan
{
    [StringLength(50)]
    [Unicode(false)]
    public string? KodeRS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KodePropinsi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KabKota { get; set; }

    [Key]
    public int Tahun { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? BOR { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? ALOS { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? BTO { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? TOI { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? NDR { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? GDR { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? RataRataKunjungan { get; set; }
}
