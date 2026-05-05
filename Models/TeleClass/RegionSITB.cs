using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RegionSITB
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KodeProvinsi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCProvinsi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaProvinsi { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KodeKota { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaKota { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
