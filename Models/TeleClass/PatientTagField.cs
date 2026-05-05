using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientTagField
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Unicode(false)]
    public string? TagField1 { get; set; }

    [Unicode(false)]
    public string? TagField2 { get; set; }

    [Unicode(false)]
    public string? TagField3 { get; set; }

    [Unicode(false)]
    public string? TagField4 { get; set; }

    [Unicode(false)]
    public string? TagField5 { get; set; }

    [Unicode(false)]
    public string? TagField6 { get; set; }

    [Unicode(false)]
    public string? TagField7 { get; set; }

    [Unicode(false)]
    public string? TagField8 { get; set; }

    [Unicode(false)]
    public string? TagField9 { get; set; }

    [Unicode(false)]
    public string? TagField10 { get; set; }

    [Unicode(false)]
    public string? TagField11 { get; set; }

    [Unicode(false)]
    public string? TagField12 { get; set; }

    [Unicode(false)]
    public string? TagField13 { get; set; }

    [Unicode(false)]
    public string? TagField14 { get; set; }

    [Unicode(false)]
    public string? TagField15 { get; set; }

    [Unicode(false)]
    public string? TagField16 { get; set; }

    [Unicode(false)]
    public string? TagField17 { get; set; }

    [Unicode(false)]
    public string? TagField18 { get; set; }

    [Unicode(false)]
    public string? TagField19 { get; set; }

    [Unicode(false)]
    public string? TagField20 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientTagField")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
