using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Employee
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CompanyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EmployeeName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReligion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMaritalStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBloodType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCEmployeeStatus { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BloodRhesus { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Height { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Weight { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCNationality { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SSN { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? STR { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SIP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SocialMedia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GcRlKualifikasiPendidikan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxRegistrant { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTaxStatus { get; set; }

    public int? PtkpStatusId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GcAgcEmployee { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BankAccountName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TerminateDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPerfomance { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OrganizationCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoFileName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPayrollPeriodType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCGolongan { get; set; }

    public int? CostServiceUnitId { get; set; }

    public bool? IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<BackPaySalary> BackPaySalary { get; set; } = new List<BackPaySalary>();

    [ForeignKey("CompanyCode")]
    [InverseProperty("Employee")]
    public virtual Company? CompanyCodeNavigation { get; set; }

    [ForeignKey("CostServiceUnitId")]
    [InverseProperty("Employee")]
    public virtual DepartmentServiceUnit? CostServiceUnit { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<DaySubstitute> DaySubstitute { get; set; } = new List<DaySubstitute>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeDisiplinaryDt> EmployeeDisiplinaryDt { get; set; } = new List<EmployeeDisiplinaryDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeFamily> EmployeeFamily { get; set; } = new List<EmployeeFamily>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeGroupDt> EmployeeGroupDt { get; set; } = new List<EmployeeGroupDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeLeave> EmployeeLeave { get; set; } = new List<EmployeeLeave>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeLoanHd> EmployeeLoanHd { get; set; } = new List<EmployeeLoanHd>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeLoanProcessDt> EmployeeLoanProcessDt { get; set; } = new List<EmployeeLoanProcessDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeMedical> EmployeeMedical { get; set; } = new List<EmployeeMedical>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeMedicalAdjustmentDt> EmployeeMedicalAdjustmentDt { get; set; } = new List<EmployeeMedicalAdjustmentDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeMedicalClaim> EmployeeMedicalClaim { get; set; } = new List<EmployeeMedicalClaim>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeSPT> EmployeeSPT { get; set; } = new List<EmployeeSPT>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeScheduleHd> EmployeeScheduleHd { get; set; } = new List<EmployeeScheduleHd>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeTerminate> EmployeeTerminate { get; set; } = new List<EmployeeTerminate>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeTimeAttendance> EmployeeTimeAttendance { get; set; } = new List<EmployeeTimeAttendance>();

    [InverseProperty("Employee")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistory { get; set; } = new List<EmployeeWorkingHistory>();

    [ForeignKey("GCBloodType")]
    [InverseProperty("EmployeeGCBloodTypeNavigation")]
    public virtual sysGeneralCode? GCBloodTypeNavigation { get; set; }

    [ForeignKey("GCEmployeeStatus")]
    [InverseProperty("EmployeeGCEmployeeStatusNavigation")]
    public virtual sysGeneralCode? GCEmployeeStatusNavigation { get; set; }

    [ForeignKey("GCGolongan")]
    [InverseProperty("EmployeeGCGolonganNavigation")]
    public virtual sysGeneralCode? GCGolonganNavigation { get; set; }

    [ForeignKey("GCMaritalStatus")]
    [InverseProperty("EmployeeGCMaritalStatusNavigation")]
    public virtual sysGeneralCode? GCMaritalStatusNavigation { get; set; }

    [ForeignKey("GCNationality")]
    [InverseProperty("EmployeeGCNationalityNavigation")]
    public virtual sysGeneralCode? GCNationalityNavigation { get; set; }

    [ForeignKey("GCPayrollPeriodType")]
    [InverseProperty("EmployeeGCPayrollPeriodTypeNavigation")]
    public virtual sysGeneralCode? GCPayrollPeriodTypeNavigation { get; set; }

    [ForeignKey("GCPerfomance")]
    [InverseProperty("EmployeeGCPerfomanceNavigation")]
    public virtual sysGeneralCode? GCPerfomanceNavigation { get; set; }

    [ForeignKey("GCReligion")]
    [InverseProperty("EmployeeGCReligionNavigation")]
    public virtual sysGeneralCode? GCReligionNavigation { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("EmployeeGCSexNavigation")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [ForeignKey("GCTaxStatus")]
    [InverseProperty("EmployeeGCTaxStatusNavigation")]
    public virtual sysGeneralCode? GCTaxStatusNavigation { get; set; }

    [ForeignKey("GcAgcEmployee")]
    [InverseProperty("EmployeeGcAgcEmployeeNavigation")]
    public virtual sysGeneralCode? GcAgcEmployeeNavigation { get; set; }

    [ForeignKey("GcRlKualifikasiPendidikan")]
    [InverseProperty("EmployeeGcRlKualifikasiPendidikanNavigation")]
    public virtual sysGeneralCode? GcRlKualifikasiPendidikanNavigation { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<LeaveAdjustmentDt> LeaveAdjustmentDt { get; set; } = new List<LeaveAdjustmentDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<LeaveCashable> LeaveCashable { get; set; } = new List<LeaveCashable>();

    [InverseProperty("Employee")]
    public virtual ICollection<LeaveRequest> LeaveRequest { get; set; } = new List<LeaveRequest>();

    [InverseProperty("Employee")]
    public virtual ICollection<MassLeaveDt> MassLeaveDt { get; set; } = new List<MassLeaveDt>();

    [InverseProperty("OrganizationHeadNavigation")]
    public virtual ICollection<Organization> Organization { get; set; } = new List<Organization>();

    [ForeignKey("OrganizationCode")]
    [InverseProperty("Employee")]
    public virtual Organization? OrganizationCodeNavigation { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<OvertimeWorkOrderDt> OvertimeWorkOrderDt { get; set; } = new List<OvertimeWorkOrderDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<PayrollProcessDt> PayrollProcessDt { get; set; } = new List<PayrollProcessDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<PayrollProcessSubDt> PayrollProcessSubDt { get; set; } = new List<PayrollProcessSubDt>();

    [ForeignKey("PositionCode")]
    [InverseProperty("Employee")]
    public virtual Position? PositionCodeNavigation { get; set; }

    [ForeignKey("PtkpStatusId")]
    [InverseProperty("Employee")]
    public virtual PTKPStatus? PtkpStatus { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<SalaryComponentEmployee> SalaryComponentEmployee { get; set; } = new List<SalaryComponentEmployee>();

    [InverseProperty("Employee")]
    public virtual ICollection<TimeAttendanceRecapDetailDt> TimeAttendanceRecapDetailDt { get; set; } = new List<TimeAttendanceRecapDetailDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<TimeAttendanceRecapDt> TimeAttendanceRecapDt { get; set; } = new List<TimeAttendanceRecapDt>();

    [InverseProperty("Employee")]
    public virtual ICollection<WorkOffPermission> WorkOffPermission { get; set; } = new List<WorkOffPermission>();
}
