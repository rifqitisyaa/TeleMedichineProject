using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysMatrixPage
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string EntityClassNameHeader { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string EntityClassNameMatrix { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string EntityClassNameSelection { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? HeaderValueFieldName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? HeaderTextFieldName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string LinkFieldNameToHeader { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? LinkFieldNameToSelection { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string SelectionValueFieldName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SelectionTextFieldName { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
