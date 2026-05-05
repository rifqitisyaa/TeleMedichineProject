using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCSex", "Age")]
public partial class sysCHDRiskChart
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [Key]
    public byte Age { get; set; }

    public byte StartValue { get; set; }

    public byte EndValue { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("sysCHDRiskChart")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;
}
