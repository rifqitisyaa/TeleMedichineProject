using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class PatientImport2
{
    [StringLength(255)]
    public string? F1 { get; set; }

    [StringLength(255)]
    public string? MRNRevisi { get; set; }

    [StringLength(255)]
    public string? MedicalNo { get; set; }

    [StringLength(255)]
    public string? title { get; set; }

    [StringLength(255)]
    public string? FirstName { get; set; }

    [StringLength(255)]
    public string? MiddleName { get; set; }

    [StringLength(255)]
    public string? LastName { get; set; }

    [StringLength(255)]
    public string? PatientName { get; set; }

    [StringLength(255)]
    public string? Sex { get; set; }

    [StringLength(255)]
    public string? GCSex { get; set; }

    [StringLength(255)]
    public string? CityOfBirth { get; set; }

    [StringLength(255)]
    public string? DateOfBirth { get; set; }

    [StringLength(255)]
    public string? F13 { get; set; }

    [StringLength(255)]
    public string? F14 { get; set; }

    [StringLength(255)]
    public string? F15 { get; set; }

    [StringLength(255)]
    public string? F16 { get; set; }

    [StringLength(255)]
    public string? F17 { get; set; }

    [StringLength(255)]
    public string? F18 { get; set; }

    [StringLength(255)]
    public string? F19 { get; set; }

    [StringLength(255)]
    public string? Line1 { get; set; }

    [StringLength(255)]
    public string? PhoneNo { get; set; }

    [StringLength(255)]
    public string? MobilePhone1 { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? ZipCode { get; set; }

    [StringLength(255)]
    public string? Province { get; set; }

    [StringLength(255)]
    public string? GCProvince { get; set; }

    [StringLength(255)]
    public string? Religion { get; set; }

    [StringLength(255)]
    public string? GCReligion { get; set; }

    [StringLength(255)]
    public string? MaritalStatus { get; set; }

    [StringLength(255)]
    public string? GCMaritalStatus { get; set; }

    [StringLength(255)]
    public string? Education { get; set; }

    [StringLength(255)]
    public string? GCEducation { get; set; }

    [StringLength(255)]
    public string? Occupation { get; set; }

    [StringLength(255)]
    public string? GCOccupation { get; set; }

    [StringLength(255)]
    public string? F35 { get; set; }

    [StringLength(255)]
    public string? GCNationality { get; set; }

    [StringLength(255)]
    public string? F37 { get; set; }

    [StringLength(255)]
    public string? F38 { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }

    [StringLength(255)]
    public string? F40 { get; set; }

    [StringLength(255)]
    public string? NumberOfVisit { get; set; }

    [StringLength(255)]
    public string? LastVisitDate { get; set; }

    [StringLength(255)]
    public string? SSN { get; set; }

    [StringLength(255)]
    public string? F44 { get; set; }

    [StringLength(255)]
    public string? TagFieldPassport { get; set; }

    [StringLength(255)]
    public string? Isactive { get; set; }

    [StringLength(255)]
    public string? TagFieldMemberNo { get; set; }

    [StringLength(255)]
    public string? IsBlacklist { get; set; }

    [StringLength(255)]
    public string? F49 { get; set; }

    [StringLength(255)]
    public string? F50 { get; set; }

    [StringLength(255)]
    public string? TagFieldMember { get; set; }

    [StringLength(255)]
    public string? Company { get; set; }

    [StringLength(255)]
    public string? Line1kantor { get; set; }

    [StringLength(255)]
    public string? Line2kantor { get; set; }

    [StringLength(255)]
    public string? CityKantor { get; set; }

    [StringLength(255)]
    public string? PhoneKantor { get; set; }

    [StringLength(255)]
    public string? F57 { get; set; }

    [StringLength(255)]
    public string? GCBloodType { get; set; }

    [StringLength(255)]
    public string? BloodRhesus { get; set; }

    [StringLength(255)]
    public string? Email1 { get; set; }

    [StringLength(255)]
    public string? TagFieldPasien { get; set; }

    [StringLength(255)]
    public string? F62 { get; set; }

    [StringLength(255)]
    public string? F63 { get; set; }

    [StringLength(255)]
    public string? TagFieldNamaInstansi { get; set; }

    [StringLength(255)]
    public string? F65 { get; set; }

    [StringLength(255)]
    public string? F66 { get; set; }

    [StringLength(255)]
    public string? F67 { get; set; }

    [StringLength(255)]
    public string? F68 { get; set; }

    [StringLength(255)]
    public string? F69 { get; set; }

    [StringLength(255)]
    public string? GCRace { get; set; }

    [StringLength(255)]
    public string? FamilyNameAyah { get; set; }

    [StringLength(255)]
    public string? JobAyah { get; set; }

    [StringLength(255)]
    public string? F73 { get; set; }

    [StringLength(255)]
    public string? FamilyNameIbu { get; set; }

    [StringLength(255)]
    public string? JobIbu { get; set; }

    [StringLength(255)]
    public string? F76 { get; set; }

    [StringLength(255)]
    public string? F77 { get; set; }

    [StringLength(255)]
    public string? F78 { get; set; }

    [StringLength(255)]
    public string? F79 { get; set; }
}
