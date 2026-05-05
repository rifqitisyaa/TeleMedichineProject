using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EmbalaceID", "SequenceNo")]
public partial class EmbalaceDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string EmbalaceID { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal StartingQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmbalaceID")]
    [InverseProperty("EmbalaceDt")]
    public virtual EmbalaceHd Embalace { get; set; } = null!;
}
