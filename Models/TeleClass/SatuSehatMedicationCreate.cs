using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SatuSehatMedicationCreate
{
    public DateOnly? batchExpirationDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? lotNumber { get; set; }

    [Unicode(false)]
    public string? codeCoding { get; set; }

    [Unicode(false)]
    public string? extensionUrl { get; set; }

    [Unicode(false)]
    public string? extensionValueCodeAbleConcept { get; set; }

    [Unicode(false)]
    public string? formCoding { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idMedicationCreate { get; set; }

    [Unicode(false)]
    public string? identifier { get; set; }

    [Unicode(false)]
    public string? ingredient { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? manufacturer { get; set; }

    [Unicode(false)]
    public string? meta { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? resourceType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? status { get; set; }
}
