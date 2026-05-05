using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PemeriksaanInfeksi
{
    [Key]
    public int PasienID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Keluhan { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PemeriksaanDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("PemeriksaanInfeksi")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PemeriksaanInfeksi")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
