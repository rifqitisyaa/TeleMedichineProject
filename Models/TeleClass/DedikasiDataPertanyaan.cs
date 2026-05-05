using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class DedikasiDataPertanyaan
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public bool? FaktorRisikoMerokok { get; set; }

    public bool? FaktorRisikoKurangSayur { get; set; }

    public bool? FaktorRisikoKurangAktivitas { get; set; }

    public bool? FaktorRisikoMinumAlkohol { get; set; }

    public bool? FaktorRisikoGulaBerlebih { get; set; }

    public bool? FaktorRisikoGaramBerlebih { get; set; }

    public bool? FaktorRisikoLemakBerlebih { get; set; }

    public bool? PenyakitSendiriDiabetes { get; set; }

    public bool? PenyakitSendiriHipertensi { get; set; }

    public bool? PenyakitSendiriDislipidemia { get; set; }

    public bool? PenyakitSendiriJantung { get; set; }

    public bool? PenyakitSendiriStroke { get; set; }

    public bool? PenyakitSendiriKanker { get; set; }

    public bool? PenyakitKeluargaDiabetes { get; set; }

    public bool? PenyakitKeluargaHipertensi { get; set; }

    public bool? PenyakitKeluargaDislipidemia { get; set; }

    public bool? PenyakitKeluargaJantung { get; set; }

    public bool? PenyakitKeluargaStroke { get; set; }

    public bool? PenyakitKeluargaKanker { get; set; }

    public bool? Hamil { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
