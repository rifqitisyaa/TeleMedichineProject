using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MedicalRecordList
{
    [Key]
    public int MedicalRecordID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string MedicalRecordName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCMedicalRecordCategory { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public int? OrderNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCMedicalRecordCategory")]
    [InverseProperty("MedicalRecordList")]
    public virtual sysGeneralCode GCMedicalRecordCategoryNavigation { get; set; } = null!;
}
