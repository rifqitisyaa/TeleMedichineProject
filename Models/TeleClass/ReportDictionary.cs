using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReportDictionary
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DictionaryCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string BaseLanguage { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string OtherLanguage { get; set; } = null!;
}
