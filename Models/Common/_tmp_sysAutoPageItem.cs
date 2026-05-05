using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class _tmp_sysAutoPageItem
{
    [StringLength(50)]
    [Unicode(false)]
    public string EntityClassName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Caption { get; set; } = null!;

    public bool? IsGridKeyField { get; set; }

    public bool? IsCustomField { get; set; }

    public int? GridColumnIndex { get; set; }

    public int? GridColumnWidth { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? GridColumnSortType { get; set; }

    public int? GridColumnShortIndex { get; set; }

    public int? GridColumnGroupIndex { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? GridColumnSortExp { get; set; }

    public bool? IsFilterAvailable { get; set; }

    public int? FilterRowIndex { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FilterControl { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FilterDefaultValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FilterAlias { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SourceEntityClassName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SourceFieldName { get; set; }

    public int? EntryRowIndex { get; set; }

    public bool? IsEntryDisableInEdit { get; set; }

    public bool? IsEntryDisableInAdd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EntryControl { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TabPageCaption { get; set; }

    public int? EntryMaxLength { get; set; }

    public bool? IsEntryMandatory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ValidationRangeStart { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ValidationRangeEnd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisplayFormatString { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InputMask { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CssClass { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LookUp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LookUpTextField { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LookUpValueField { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LookUpCustomMethod { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? NullText { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
