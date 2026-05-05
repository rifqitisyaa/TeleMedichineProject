using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SysPatientMergeDt
{
    [Key]
    public int Id { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string MenuId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Field1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Filed2 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Field3 { get; set; } = null!;

    public bool IsDeletedData { get; set; }

    public bool IsUpdateData { get; set; }

    public bool IsReorderNo { get; set; }

    public bool IsUpdateWithStarMrn { get; set; }

    public bool IsHeaderDetail { get; set; }

    public bool IsForeignKey { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string UpdateFieldNonPrimaryKey { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string UpdateValueNonPrimaryKey { get; set; } = null!;

    public int SeqNoFormat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TableRelated { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TableRelatedKey { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TableRelatedPrimaryKey1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TableRelatedPrimaryKey2 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PrimaryKeyField1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PrimaryKeyField2 { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
