using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratPernyataanRujukan
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? letterDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FamilyName { get; set; }

    [Unicode(false)]
    public string? FamilyAddress { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FamilyPhone { get; set; }

    public int? ParamedicId { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ImgTtd1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? txtTtd1 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ImgTtd2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? txtTtd2 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ImgTtd3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? txtTtd3 { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
