using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterAddress
{
    [Unicode(false)]
    public string? AddressCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string AddressCodeType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? AddressType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Line1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Line2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Village { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? County { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Province { get; set; }

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
}
