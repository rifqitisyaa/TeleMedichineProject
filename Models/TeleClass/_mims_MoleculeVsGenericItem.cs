using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MoleculeReferenceID", "GenericItemReferenceID")]
public partial class _mims_MoleculeVsGenericItem
{
    [Key]
    public Guid MoleculeReferenceID { get; set; }

    [Key]
    public Guid GenericItemReferenceID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MoleculeName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? GenericItemName { get; set; }
}
