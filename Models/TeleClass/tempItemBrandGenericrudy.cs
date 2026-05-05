using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempItemBrandGenericrudy
{
    public long? Sequence { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BrandCode { get; set; } = null!;

    public int GenericID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string GenericName { get; set; } = null!;
}
