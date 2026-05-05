using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CorporateReference
{
    [Key]
    public int CorporateReferenceID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CorporateReferenceCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CorporateReferenceName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? CorporateReferenceType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson1Name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ContactPerson2Name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ContactPerson1PhoneNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ContactPerson2PhoneNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
