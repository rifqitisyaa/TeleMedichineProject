using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CHDAge
{
    [Key]
    public int CHDAgeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    public int AgeFrom { get; set; }

    public int AgeTo { get; set; }

    public int LDLPts { get; set; }

    public int CholPts { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("CHDAge")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;
}
