using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReferenceNo", "dob", "Sequence", "DetailSequence")]
public partial class RegistrationMCUDataList
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Key]
    public int dob { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string Sequence { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string DetailSequence { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ssn { get; set; }

    [Unicode(false)]
    public string? jabatan { get; set; }

    [Unicode(false)]
    public string? ParameterGrouping { get; set; }

    [Unicode(false)]
    public string? parameterData { get; set; }

    [Unicode(false)]
    public string? valueData { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDataDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDatabaseDatetime { get; set; }

    public bool? IsAlreadyMCU { get; set; }

    public bool? IsShowInReport { get; set; }
}
