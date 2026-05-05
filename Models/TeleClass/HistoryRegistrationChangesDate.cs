using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HistoryRegistrationChangesDate
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegistrationChangesDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Unicode(false)]
    public string? Reason { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDatetime { get; set; }
}
