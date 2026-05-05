using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class vw_aspnet_UsersInRoles
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }
}
