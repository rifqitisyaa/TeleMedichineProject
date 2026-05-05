using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ImagingStudySingleImage
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? identifierSystem { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? identifierValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? numberOfSeries { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? numberOfInstances1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? seriesUID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? seriesNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? numberOfInstances2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? instanceUID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? sopClassSystem { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? sopClassCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? number { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IsUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedDateTime { get; set; }
}
