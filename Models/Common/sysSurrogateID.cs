using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysSurrogateID
{
    [Key]
    [StringLength(35)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string CodeFieldName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string IdentityFieldName { get; set; } = null!;
}
