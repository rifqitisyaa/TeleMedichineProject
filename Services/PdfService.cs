using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using TeleMedichineProject.Models.TeleClass;

namespace TeleMedichineProject.Services
{
    public class PrescriptionPrintData
    {
        public string RegistrationNo  { get; set; } = string.Empty;
        public string PatientName     { get; set; } = string.Empty;
        public string MedicalNo       { get; set; } = string.Empty;
        public string DoctorName      { get; set; } = string.Empty;
        public string SiteCode        { get; set; } = string.Empty;
        public DateTime PrintDate     { get; set; } = DateTime.Now;
        public List<PrescriptionItem> Items { get; set; } = [];
    }

    public class PrescriptionItem
    {
        public string ItemName  { get; set; } = string.Empty;
        public string Dose      { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public string Route     { get; set; } = string.Empty;
        public string Signa     { get; set; } = string.Empty;
        public decimal Qty      { get; set; }
        public string Unit      { get; set; } = string.Empty;
        public string? Remarks  { get; set; }
    }

    public interface IPdfService
    {
        byte[] GeneratePrescription(PrescriptionPrintData data);
        byte[] GenerateSoapNote(SoapPrintData data);
    }

    public class SoapPrintData
    {
        public string RegistrationNo  { get; set; } = string.Empty;
        public string PatientName     { get; set; } = string.Empty;
        public string MedicalNo       { get; set; } = string.Empty;
        public string DoctorName      { get; set; } = string.Empty;
        public DateTime VisitDate     { get; set; }
        public string Subjective      { get; set; } = string.Empty;
        public string Objective       { get; set; } = string.Empty;
        public string Assessment      { get; set; } = string.Empty;
        public string Planning        { get; set; } = string.Empty;
    }

    public class PdfService : IPdfService
    {
        public PdfService()
        {
            // Set QuestPDF community license (free)
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public byte[] GeneratePrescription(PrescriptionPrintData data)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(20);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                    page.Header().Column(header =>
                    {
                        header.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("RESEP DOKTER")
                                   .FontSize(14).Bold().FontColor("#1B3A6B");
                                col.Item().Text($"No. Registrasi: {data.RegistrationNo}")
                                   .FontSize(9).FontColor("#64748B");
                            });
                            row.ConstantItem(80).AlignRight().Column(col =>
                            {
                                col.Item().Text(data.PrintDate.ToString("dd MMM yyyy"))
                                   .FontSize(9).FontColor("#64748B");
                                col.Item().Text(data.PrintDate.ToString("HH:mm"))
                                   .FontSize(9).FontColor("#64748B");
                            });
                        });

                        header.Item().PaddingTop(4).BorderBottom(1).BorderColor("#E2E8F0");

                        header.Item().PaddingTop(6).Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Pasien").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.PatientName).FontSize(11).Bold();
                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("No. RM").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.MedicalNo).FontSize(10);
                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Dokter").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.DoctorName).FontSize(10);
                            });
                        });

                        header.Item().PaddingTop(8).BorderBottom(1).BorderColor("#E2E8F0");
                    });

                    page.Content().PaddingTop(10).Column(content =>
                    {
                        content.Item().Text("R/").FontSize(12).Bold().FontColor("#1B3A6B");

                        for (int i = 0; i < data.Items.Count; i++)
                        {
                            var item = data.Items[i];
                            content.Item().PaddingTop(8).Row(row =>
                            {
                                row.ConstantItem(16).Text($"{i + 1}.").FontSize(9).FontColor("#94A3B8");
                                row.RelativeItem().Column(col =>
                                {
                                    col.Item().Text(item.ItemName).Bold().FontSize(10);
                                    col.Item().PaddingTop(2).Row(r =>
                                    {
                                        r.RelativeItem().Text($"Dosis: {item.Dose}  |  Frekuensi: {item.Frequency}  |  Rute: {item.Route}")
                                         .FontSize(9).FontColor("#475569");
                                    });
                                    col.Item().Text($"Signa: {item.Signa}  —  Qty: {item.Qty} {item.Unit}")
                                       .FontSize(9).FontColor("#475569");
                                    if (!string.IsNullOrEmpty(item.Remarks))
                                        col.Item().Text($"Catatan: {item.Remarks}").FontSize(8).Italic().FontColor("#94A3B8");
                                });
                            });

                            content.Item().PaddingTop(6).LineHorizontal(0.5f).LineColor("#F1F5F9");
                        }
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Dicetak oleh sistem TelemedPro — ").FontSize(8).FontColor("#94A3B8");
                        text.Span(data.PrintDate.ToString("dd/MM/yyyy HH:mm")).FontSize(8).FontColor("#94A3B8");
                    });
                });
            }).GeneratePdf();
        }

        public byte[] GenerateSoapNote(SoapPrintData data)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                    page.Header().Column(header =>
                    {
                        header.Item().Text("CATATAN MEDIS — SOAP")
                              .FontSize(16).Bold().FontColor("#1B3A6B");
                        header.Item().PaddingTop(4).BorderBottom(1).BorderColor("#E2E8F0");
                        header.Item().PaddingTop(8).Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Pasien").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.PatientName).Bold();
                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("No. Registrasi").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.RegistrationNo);
                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Dokter").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.DoctorName);
                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Tanggal Kunjungan").FontSize(8).FontColor("#94A3B8");
                                col.Item().Text(data.VisitDate.ToString("dd MMM yyyy HH:mm"));
                            });
                        });
                        header.Item().PaddingTop(8).BorderBottom(1).BorderColor("#E2E8F0");
                    });

                    page.Content().PaddingTop(16).Column(content =>
                    {
                        void AddSoapSection(string label, string color, string value)
                        {
                            content.Item().PaddingBottom(12).Column(col =>
                            {
                                col.Item().Text(label).Bold().FontSize(11).FontColor(color);
                                col.Item().PaddingTop(4).Background("#F8FAFC").Padding(10)
                                   .Text(string.IsNullOrWhiteSpace(value) ? "-" : value)
                                   .FontSize(10).LineHeight(1.5f);
                            });
                        }

                        AddSoapSection("S — Subjective", "#0EA5E9", data.Subjective);
                        AddSoapSection("O — Objective",  "#16A34A", data.Objective);
                        AddSoapSection("A — Assessment", "#DC2626", data.Assessment);
                        AddSoapSection("P — Planning",   "#7C3AED", data.Planning);
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("TelemedPro — ").FontSize(8).FontColor("#94A3B8");
                        text.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm")).FontSize(8).FontColor("#94A3B8");
                    });
                });
            }).GeneratePdf();
        }
    }
}
