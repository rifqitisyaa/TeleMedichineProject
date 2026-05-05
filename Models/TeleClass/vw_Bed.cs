using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Bed
{
    public int BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BedCode { get; set; } = null!;

    public int? ServiceUnitID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClassName { get; set; } = null!;

    public int? ItemID { get; set; }
}
