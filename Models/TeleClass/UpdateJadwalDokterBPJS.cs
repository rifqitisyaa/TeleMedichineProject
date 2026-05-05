using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ParamedicID", "ServiceUnitID", "DayCode")]
public partial class UpdateJadwalDokterBPJS
{
    [Key]
    public int ParamedicID { get; set; }

    [Key]
    public int ServiceUnitID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DayCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CustomerServiceUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CustomerSubSpecialistCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerServiceUnitName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CustomerParamedicCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerParamedicName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DayName { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? StartingTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EndingTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
