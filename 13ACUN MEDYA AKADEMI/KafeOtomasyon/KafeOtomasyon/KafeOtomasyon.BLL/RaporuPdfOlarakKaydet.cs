using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using KafeOtomasyon.Entities.Models; // Satis için

public class RaporOlusturucu
{
    public void RaporuPdfOlarakKaydet(List<Satis> satislar)
    {
        string path = @"C:\Raporlar\GunlukSatisRaporu.pdf";

        Directory.CreateDirectory(Path.GetDirectoryName(path)); // Klasörü oluştur

        using (PdfWriter writer = new PdfWriter(path))
        using (PdfDocument pdf = new PdfDocument(writer))
        using (Document document = new Document(pdf))
        {
            var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            document.Add(new Paragraph("Günlük Satış Raporu")
                .SetFont(boldFont)
                .SetFontSize(18));

            foreach (var s in satislar)
            {
                document.Add(new Paragraph($"Ürün: {s.UrunAdi} - Adet: {s.Adet} - Tutar: {s.Tutar}₺"));
            }

            document.Add(new Paragraph($"Toplam Tutar: {satislar.Sum(x => x.Tutar)}₺")
                .SetFont(boldFont));
        }

        MessageBox.Show("PDF başarıyla oluşturuldu.", "Rapor", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
