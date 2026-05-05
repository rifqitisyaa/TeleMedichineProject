using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CityLookUp
{
    [Key]
    public int CityId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CityName { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }
}
