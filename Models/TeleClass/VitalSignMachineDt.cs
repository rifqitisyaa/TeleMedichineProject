using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class VitalSignMachineDt
{
    [StringLength(20)]
    [Unicode(false)]
    public string? Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VitalSignGroupCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VitalSignCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VitalSignValue { get; set; }

    [StringLength(10)]
    public string? IsDeleted { get; set; }
}
