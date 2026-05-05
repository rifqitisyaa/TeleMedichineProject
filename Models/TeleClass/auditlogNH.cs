using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class auditlogNH
{
    [StringLength(255)]
    public string? FirstName { get; set; }

    [StringLength(255)]
    public string? MenuCaption1 { get; set; }

    [StringLength(255)]
    public string? TableName { get; set; }

    [StringLength(255)]
    public string? AuditLogID { get; set; }

    [StringLength(255)]
    public string? TableName1 { get; set; }

    [StringLength(255)]
    public string? ActionType { get; set; }

    [StringLength(255)]
    public string? PrimaryKeyData { get; set; }

    public string? LogData { get; set; }

    [StringLength(255)]
    public string? HostName { get; set; }

    [StringLength(255)]
    public string? AppName { get; set; }

    [StringLength(255)]
    public string? UserID { get; set; }

    [StringLength(255)]
    public string? LogDateTime { get; set; }

    [StringLength(255)]
    public string? MenuID { get; set; }

    [StringLength(255)]
    public string? LogID { get; set; }
}
