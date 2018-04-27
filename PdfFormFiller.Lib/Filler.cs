using iTextSharp.text.pdf;
using System.IO;

namespace PdfFormFiller.Lib
{
    public class Filler
    {
        public static void Fill(string pdfformFile)
        {
            iTextSharp.text.pdf.PdfReader pdfreader = new iTextSharp.text.pdf.PdfReader(pdfformFile);

            //PdfReader..unethicalreading = true;

            MemoryStream pdfms = new MemoryStream();

            PdfStamper pdfStamper = new PdfStamper(pdfreader, pdfms, '\0', true);

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            pdfFormFields.GenerateAppearances = true;

            pdfFormFields.SetField("IP_NAME", "TESTING", "TESTING");

            //pdfStamper.FormFlattening = true;

            pdfStamper.Close();
            pdfreader.Close();
            pdfms.Flush();
            pdfms.Close();
        }
    }
}