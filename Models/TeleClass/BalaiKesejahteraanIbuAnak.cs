using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BalaiKesejahteraanIbuAnak
{
    public int? Hamilke { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Aterm { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Riwayat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Puerperium { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tolong { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Keadaan { get; set; }
}
