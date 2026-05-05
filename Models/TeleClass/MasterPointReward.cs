using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class MasterPointReward
{
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CustomerCategoryCode { get; set; } = null!;

    public int Point { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? ItemName { get; set; }
}
