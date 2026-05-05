using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ZipCodes
{
    [Key]
    public int ZipCodeID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string ZipCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Line1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Line2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string District { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string County { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCProvince { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ZipCode")]
    public virtual ICollection<Address> Address { get; set; } = new List<Address>();

    [ForeignKey("GCProvince")]
    [InverseProperty("ZipCodes")]
    public virtual sysGeneralCode? GCProvinceNavigation { get; set; }
}
