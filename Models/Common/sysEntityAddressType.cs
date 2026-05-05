using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Index("EntityClassName", "GCAddressType", Name = "IX_sysEntityAddressType", IsUnique = true)]
public partial class sysEntityAddressType
{
    [Key]
    public long EntityAddressID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string EntityClassName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCAddressType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
