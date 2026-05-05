using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QueuingTVGeneralCode
{
    [Key]
    public int Id { get; set; }

    public int? ParamedicId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GeneralCodeID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Remarks { get; set; }
}
