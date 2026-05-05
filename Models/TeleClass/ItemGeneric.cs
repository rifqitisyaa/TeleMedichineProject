using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemGeneric
{
    [Key]
    public int GenericID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string GenericName { get; set; } = null!;

    public Guid? MimsReferenceID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? IsAntibiotik { get; set; }

    [InverseProperty("Generic")]
    public virtual ICollection<DrugInteraction> DrugInteractionGeneric { get; set; } = new List<DrugInteraction>();

    [InverseProperty("InteractingGeneric")]
    public virtual ICollection<DrugInteraction> DrugInteractionInteractingGeneric { get; set; } = new List<DrugInteraction>();

    [InverseProperty("Generic")]
    public virtual ICollection<ItemBrandGeneric> ItemBrandGeneric { get; set; } = new List<ItemBrandGeneric>();

    [InverseProperty("Generic")]
    public virtual ICollection<PatientAntibiotik> PatientAntibiotik { get; set; } = new List<PatientAntibiotik>();
}
