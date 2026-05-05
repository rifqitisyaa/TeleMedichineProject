using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("Initial", Name = "IX_Department", IsUnique = true)]
public partial class Department
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    public byte DisplayOrder { get; set; }

    public bool IsHasRegistration { get; set; }

    public bool IsHasPrescription { get; set; }

    public bool IsGenerateMedicalNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<AccountPeriod> AccountPeriod { get; set; } = new List<AccountPeriod>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<AllocationCodeDt> AllocationCodeDt { get; set; } = new List<AllocationCodeDt>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; } = new List<ItemTransactionHistoryDt>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<JournalCashBankDt> JournalCashBankDt { get; set; } = new List<JournalCashBankDt>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHd { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<JournalDt> JournalDt { get; set; } = new List<JournalDt>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<JournalHd> JournalHd { get; set; } = new List<JournalHd>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<ParamedicAutoBill> ParamedicAutoBill { get; set; } = new List<ParamedicAutoBill>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<PemeriksaanInfeksi> PemeriksaanInfeksi { get; set; } = new List<PemeriksaanInfeksi>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<RecuringSubDt> RecuringSubDt { get; set; } = new List<RecuringSubDt>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<SiteDepartment> SiteDepartment { get; set; } = new List<SiteDepartment>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("DepartmentCodeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();
}
