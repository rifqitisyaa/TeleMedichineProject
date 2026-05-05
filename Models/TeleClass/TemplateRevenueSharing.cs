using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateRevenueSharing
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ByClass { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ByPayer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ByItem { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ByCustom { get; set; }
}
