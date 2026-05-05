using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class POR_Reference
{
    [Key]
    public int id { get; set; }

    [Unicode(false)]
    public string? item_id { get; set; }

    [Unicode(false)]
    public string? unit { get; set; }

    [Unicode(false)]
    public string? qty { get; set; }

    [Unicode(false)]
    public string? expired_date { get; set; }

    [Unicode(false)]
    public string? batch_no { get; set; }

    [Unicode(false)]
    public string? por_no { get; set; }
}
