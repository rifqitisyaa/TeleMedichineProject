using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class _bak_sysUser
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? MiddleName { get; set; }
}
