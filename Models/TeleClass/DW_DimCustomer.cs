using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimCustomer
{
    [Key]
    public int CustomerID { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    public int? CustomerTypeID { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [ForeignKey("CustomerTypeID")]
    [InverseProperty("DW_DimCustomer")]
    public virtual DW_DimCustomerType? CustomerType { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
