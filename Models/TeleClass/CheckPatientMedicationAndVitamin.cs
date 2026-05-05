using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CheckPatientMedicationAndVitamin
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public bool? VitaminAMerahYa { get; set; }

    public bool? VitaminAMerahTidak { get; set; }

    public bool? VitaminABiruYa { get; set; }

    public bool? VitaminABiruTidak { get; set; }

    public bool? ObatCacingYa { get; set; }

    public bool? ObatCacingTidak { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("CheckPatientMedicationAndVitamin")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
