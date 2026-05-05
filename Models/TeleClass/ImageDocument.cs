using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ImageDocument
{
    [Key]
    public int DocumentID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCImageType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Document")]
    public virtual ICollection<IPAddressQueue> IPAddressQueue { get; set; } = new List<IPAddressQueue>();
}
