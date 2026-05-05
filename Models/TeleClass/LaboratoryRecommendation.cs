using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LaboratoryRecommendation
{
    [Key]
    public int ID { get; set; }

    public int ItemID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ResultValue { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Saran { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
