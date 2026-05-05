using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class SerahTerimaBayi
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? NMHandOverDateTime { get; set; }

    [Column(TypeName = "image")]
    public byte[]? NMSignMother { get; set; }

    [Column(TypeName = "image")]
    public byte[]? NMSignNurse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MNHandOverDateTime { get; set; }

    [Column(TypeName = "image")]
    public byte[]? MNSignMother { get; set; }

    [Column(TypeName = "image")]
    public byte[]? MNSignNurse { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
