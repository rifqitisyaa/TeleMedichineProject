using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("ReferenceID", Name = "IX__mims_ItemGeneric")]
public partial class _mims_ItemGeneric
{
    [Key]
    public Guid ReferenceID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string GenericName { get; set; } = null!;
}
