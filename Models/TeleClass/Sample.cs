using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Sample
{
    [Key]
    public int SampleID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SampleCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SampleName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SampleName2 { get; set; }

    public int? OrderNo { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDisplayedOnReport { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Sample")]
    public virtual ICollection<TatBarcodeScan> TatBarcodeScan { get; set; } = new List<TatBarcodeScan>();
}
