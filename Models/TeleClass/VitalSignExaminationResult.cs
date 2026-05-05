using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class VitalSignExaminationResult
{
    [StringLength(100)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nation { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? qrCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dob { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? idNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? age { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? data { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? height { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? weight { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bmi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? zflv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? jcdx { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tsfl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tsflv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? zfl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? jrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? jrlv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? gy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? qztz { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dbzlv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xbnyl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xbwyl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xbnylv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xbwylv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dbz { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nzzf { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? gl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bloodHigh { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bloodLow { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bloodRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bloodRhigh { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bloodRlow { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? spo2SP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tiwen { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecgResult { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecgData { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecgLen { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Data { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12EcgResult { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Heartrate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12P_Axis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12QrsAxis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12tAxis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Pr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Qrs { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Qt { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Qtc { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Rv5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12Sv1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12SampleRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ecg12SampleTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xtType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xtValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ytbWaist { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ytbHip { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ytbWhr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? fgnPef { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? fgnfevl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? fgnFvc { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? fgnBz { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ns { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dgc { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? zybs { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? shiliLeftEye { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? shiliRightEye { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? semang { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpUcla { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpLnyy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpZpyy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpHmdjl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpQxjkpd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpZcjkpd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpShmyd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpRgza { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpPstr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpHfxx { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpEq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? xlcpSmzkpg { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeviceID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExamNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    public bool? IsDeleted { get; set; }
}
