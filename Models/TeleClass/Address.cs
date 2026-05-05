using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EntityClassName", "EntityRecordID", "GCAddressType")]
[Index("EntityRecordID", "GCAddressType", Name = "IXGCAddressType_Address")]
public partial class Address
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string EntityClassName { get; set; } = null!;

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string EntityRecordID { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCAddressType { get; set; } = null!;

    [Unicode(false)]
    public string? Line1 { get; set; }

    [Unicode(false)]
    public string? Line2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SubDistrict { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCProvince { get; set; }

    public int? ZipCodeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNo1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNo2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FaxNo1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FaxNo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email2 { get; set; }

    public bool IsMailingAddress { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DeletedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeletedDate { get; set; }

    [ForeignKey("GCAddressType")]
    [InverseProperty("AddressGCAddressTypeNavigation")]
    public virtual sysGeneralCode GCAddressTypeNavigation { get; set; } = null!;

    [ForeignKey("GCProvince")]
    [InverseProperty("AddressGCProvinceNavigation")]
    public virtual sysGeneralCode? GCProvinceNavigation { get; set; }

    [ForeignKey("ZipCodeID")]
    [InverseProperty("Address")]
    public virtual ZipCodes? ZipCode { get; set; }
}
