using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class HL7_PID
{
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OldMedicalNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SuffixName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrefixName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DateOfBirth { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [Unicode(false)]
    public string? Address1 { get; set; }

    [Unicode(false)]
    public string? Address2 { get; set; }

    [Unicode(false)]
    public string? District { get; set; }

    [Unicode(false)]
    public string? City { get; set; }

    [Unicode(false)]
    public string? Nationality { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhone1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhone2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Departement { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Division { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Position { get; set; }

    public bool IsReceived { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
