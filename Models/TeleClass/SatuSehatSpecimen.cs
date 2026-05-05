using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatSpecimen
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string SpecimenID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceRequestID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CollectionCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CollectionName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TypeCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TypeName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
