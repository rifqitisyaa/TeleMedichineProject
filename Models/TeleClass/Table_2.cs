using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "SpecialtyCode")]
public partial class Table_2
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string CustomerSpecialtyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerSpecialtyName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
