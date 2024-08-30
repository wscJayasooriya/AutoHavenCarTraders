using iTextSharp.testutils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Helpers
{
    public class ExportDataPdfUtil
    {
        public void ExportGridDataToPdf(DataGridView dataGridView, string filename, List<string> columnsToInclude, string reportTopic)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(columnsToInclude.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD | iTextSharp.text.Font.UNDERLINE);

            Paragraph timeCell = new Paragraph(new Phrase(DateTime.Now.ToString("MMMM dd, yyyy HH:mm:ss"), text));
            timeCell.Alignment = Element.ALIGN_RIGHT;

            Paragraph title = new Paragraph(reportTopic, titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (columnsToInclude.Contains(column.Name))
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPTable.AddCell(cell);
                }
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (columnsToInclude.Contains(dataGridView.Columns[cell.ColumnIndex].Name))
                    {
                        pdfPTable.AddCell(new Phrase(cell.Value?.ToString(), text));
                    }
                }
            }

            var savePdf = new SaveFileDialog();
            savePdf.FileName = filename;
            savePdf.DefaultExt = ".pdf";
            if (savePdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savePdf.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(timeCell);
                    pdfDoc.Add(title);
                    pdfDoc.Add(pdfPTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

    }
}
