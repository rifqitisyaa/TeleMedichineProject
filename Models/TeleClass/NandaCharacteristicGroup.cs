using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaCharacteristicGroup
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaCharacteristicGroupCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NandaCharacteristicGroupName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SubGroupName { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NandaCharacteristicGroupCodeNavigation")]
    public virtual ICollection<NandaCharacteristic> NandaCharacteristic { get; set; } = new List<NandaCharacteristic>();
}
