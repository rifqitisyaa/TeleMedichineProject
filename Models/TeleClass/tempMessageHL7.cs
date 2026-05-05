using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class tempMessageHL7
{
    [Key]
    public int ID { get; set; }

    [Unicode(false)]
    public string Message { get; set; } = null!;
}
