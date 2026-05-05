using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimDate
{
    [Key]
    public int DateID { get; set; }

    public DateOnly Date { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string MonthName { get; set; } = null!;

    public int Day { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DayName { get; set; } = null!;

    public int QuarterNumber { get; set; }

    [InverseProperty("DateOfDeath")]
    public virtual ICollection<DW_DimPatient> DW_DimPatient { get; set; } = new List<DW_DimPatient>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactAPMovement> DW_FactAPMovement { get; set; } = new List<DW_FactAPMovement>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactBalanceStock> DW_FactBalanceStock { get; set; } = new List<DW_FactBalanceStock>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOInDate { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriodeDate { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriodeTransactionDate { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOInTransactionDate { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOutDate { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOutTransactionDate { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOInDate { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactFIFOInPeriode> DW_FactFIFOInPeriodeDate { get; set; } = new List<DW_FactFIFOInPeriode>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactFIFOInPeriode> DW_FactFIFOInPeriodeTransactionDate { get; set; } = new List<DW_FactFIFOInPeriode>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOInTransactionDate { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOutDate { get; set; } = new List<DW_FactFIFOOut>();

    [InverseProperty("TransactionDate")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOutTransactionDate { get; set; } = new List<DW_FactFIFOOut>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactMaterialCost> DW_FactMaterialCost { get; set; } = new List<DW_FactMaterialCost>();

    [InverseProperty("ClosedDate")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceClosedDate { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("DischargeDate")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceDischargeDate { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("RegistrationDate")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceRegistrationDate { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("Date")]
    public virtual ICollection<DW_FactPharmacySales> DW_FactPharmacySales { get; set; } = new List<DW_FactPharmacySales>();
}
