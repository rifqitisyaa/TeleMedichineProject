using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimCustomerType
{
    [Key]
    public int CustomerTypeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CustomerTypeCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerTypeName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("CustomerType")]
    public virtual ICollection<DW_DimCustomer> DW_DimCustomer { get; set; } = new List<DW_DimCustomer>();
}
