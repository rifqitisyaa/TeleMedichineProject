using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ServiceUnit
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? IconFileName { get; set; }

    public bool IsUsingJobOrder { get; set; }

    public byte PatientServiceInterval { get; set; }

    public bool IsBor { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool IsExecutive { get; set; }

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<AccountPeriod> AccountPeriod { get; set; } = new List<AccountPeriod>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<AllocationCodeDt> AllocationCodeDt { get; set; } = new List<AllocationCodeDt>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<CustomerServiceUnit> CustomerServiceUnit { get; set; } = new List<CustomerServiceUnit>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<DepartmentServiceUnit> DepartmentServiceUnit { get; set; } = new List<DepartmentServiceUnit>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<InventoryAmountHistory> InventoryAmountHistory { get; set; } = new List<InventoryAmountHistory>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; } = new List<ItemTransactionHistoryDt>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<JournalCashBankDt> JournalCashBankDt { get; set; } = new List<JournalCashBankDt>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHd { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<JournalDt> JournalDt { get; set; } = new List<JournalDt>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<JournalHd> JournalHd { get; set; } = new List<JournalHd>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<RecuringSubDt> RecuringSubDt { get; set; } = new List<RecuringSubDt>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("ServiceUnitCodeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();
}
