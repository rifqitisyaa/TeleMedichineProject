using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class FormPasienBPJSRajal
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DateOfBirth { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NoRM { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [Unicode(false)]
    public string? Keluhan { get; set; }

    [Unicode(false)]
    public string? TandaVital { get; set; }

    [Unicode(false)]
    public string? PemeriksaanPenunjang { get; set; }

    [Unicode(false)]
    public string? Terapi { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaUtama { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaSekunder { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaSekunder2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TindakanProsedur { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TindakanProsedur2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TindakanProsedur3 { get; set; }

    [Unicode(false)]
    public string? LainLain { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ICD10 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ICD102 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ICD103 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ICD9CM { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ICD9CM2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ICD9CM3 { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
