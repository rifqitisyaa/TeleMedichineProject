using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysTagField
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCBusinessObject { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField3 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField5 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField6 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField7 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField8 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField9 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField10 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField11 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField12 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField13 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField14 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField15 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField16 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField17 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField18 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField19 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TagField20 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCBusinessObject")]
    [InverseProperty("sysTagField")]
    public virtual sysGeneralCode GCBusinessObjectNavigation { get; set; } = null!;
}
