using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimTime
{
    [Key]
    public int TimeID { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string Time { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Time24 { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string HourName { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string MinuteName { get; set; } = null!;

    public byte HourNumber { get; set; }

    public byte Hour24 { get; set; }

    public byte MinuteNumber { get; set; }

    public byte SecondNumber { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string AMPM { get; set; } = null!;

    public int ElapsedMinutes { get; set; }

    public int ElapsedSeconds { get; set; }

    [InverseProperty("TimeOfDeath")]
    public virtual ICollection<DW_DimPatient> DW_DimPatient { get; set; } = new List<DW_DimPatient>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactAPMovement> DW_FactAPMovement { get; set; } = new List<DW_FactAPMovement>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOIn { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriode { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOut { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOIn { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactFIFOInPeriode> DW_FactFIFOInPeriode { get; set; } = new List<DW_FactFIFOInPeriode>();

    [InverseProperty("TransactionDateTime")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOut { get; set; } = new List<DW_FactFIFOOut>();

    [InverseProperty("Time")]
    public virtual ICollection<DW_FactMaterialCost> DW_FactMaterialCost { get; set; } = new List<DW_FactMaterialCost>();
}
