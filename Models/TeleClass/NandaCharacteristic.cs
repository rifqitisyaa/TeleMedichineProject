using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaCharacteristic
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaCharacteristicCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NandaCharacteristicName { get; set; } = null!;

    [Unicode(false)]
    public string? NandaCharacteristicName2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string NandaCharacteristicGroupCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaCharacteristicGroupCode")]
    [InverseProperty("NandaCharacteristic")]
    public virtual NandaCharacteristicGroup NandaCharacteristicGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("NandaCode")]
    [InverseProperty("NandaCharacteristic")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [InverseProperty("NandaCharacteristicCodeNavigation")]
    public virtual ICollection<NursingCareplanCharacteristic> NursingCareplanCharacteristic { get; set; } = new List<NursingCareplanCharacteristic>();
}
