using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ExpiredDateSimulation
{
    [Key]
    public int ItemID { get; set; }

    public DateOnly? LastExpiredDate { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ExpiredDateSimulation")]
    public virtual Item Item { get; set; } = null!;
}
