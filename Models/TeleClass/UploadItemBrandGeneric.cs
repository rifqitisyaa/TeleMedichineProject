using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class UploadItemBrandGeneric
{
    [StringLength(255)]
    public string? itemid { get; set; }

    [StringLength(255)]
    public string? itemname1 { get; set; }

    [StringLength(255)]
    public string? brandcode { get; set; }

    [StringLength(255)]
    public string? brandname { get; set; }

    [StringLength(255)]
    public string? BahanAktif1 { get; set; }

    [StringLength(255)]
    public string? BahanAktif2 { get; set; }

    [StringLength(255)]
    public string? BahanAktif3 { get; set; }

    [StringLength(255)]
    public string? BahanAktif4 { get; set; }

    [StringLength(255)]
    public string? BahanAktif5 { get; set; }

    [StringLength(255)]
    public string? BahanAktif6 { get; set; }

    [StringLength(255)]
    public string? BahanAktif7 { get; set; }

    [StringLength(255)]
    public string? BahanAktif8 { get; set; }

    [StringLength(255)]
    public string? BahanAktif9 { get; set; }

    [StringLength(255)]
    public string? BahanAktif10 { get; set; }

    [StringLength(255)]
    public string? BahanAktif11 { get; set; }

    [StringLength(255)]
    public string? BahanAktif12 { get; set; }

    [StringLength(255)]
    public string? BahanAktif13 { get; set; }

    [StringLength(255)]
    public string? BahanAktif14 { get; set; }

    [StringLength(255)]
    public string? BahanAktif15 { get; set; }

    [StringLength(255)]
    public string? BahanAktif16 { get; set; }

    [StringLength(255)]
    public string? BahanAktif17 { get; set; }

    [StringLength(255)]
    public string? BahanAktif18 { get; set; }

    [StringLength(255)]
    public string? BahanAktif19 { get; set; }

    [StringLength(255)]
    public string? BahanAktif20 { get; set; }

    [StringLength(255)]
    public string? BahanAktif21 { get; set; }

    [StringLength(255)]
    public string? BahanAktif22 { get; set; }

    [StringLength(255)]
    public string? BahanAktif23 { get; set; }
}
