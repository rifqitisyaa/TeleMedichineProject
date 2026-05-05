using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class VitalSignMachineHd
{
    [StringLength(20)]
    [Unicode(false)]
    public string? Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nation { get; set; }

    [Unicode(false)]
    public string? qrCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dob { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? age { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? address { get; set; }

    [Unicode(false)]
    public string? data { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }
}
