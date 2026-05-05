using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class vw_aspnet_Profiles
{
    public Guid UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    public int? DataSize { get; set; }
}
