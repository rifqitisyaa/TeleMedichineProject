using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BussinesPartnerID", "GCKecamatanCode")]
public partial class CustomerKecamatan
{
    [Key]
    public int BussinesPartnerID { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCKecamatanCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CustomerKecCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CutomerKecName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
