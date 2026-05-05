using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QueuingParameter
{
    [Key]
    public int ParamedicID { get; set; }

    public int StartQueueNo { get; set; }
}
