using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CustomerBank
{
    [Key]
    public long CustomerBankId { get; set; }

    public int BusinessPartnerID { get; set; }

    public int BankID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("CustomerBank")]
    public virtual Bank Bank { get; set; } = null!;

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerBank")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;
}
