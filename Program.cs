using System;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;

class Program
{
    static void Main(string[] args)
    {
        // Path to the HTML file
        string htmlFilePath = "webpage.html";

        // Read the HTML content from the file
        string htmlContent = File.ReadAllText(htmlFilePath);

        // Create a new PDF document
        PdfDocument pdfDocument = PdfGenerator.GeneratePdf(htmlContent, PageSize.A4);

        // Save the PDF document to a file
        string pdfFilePath = "output.pdf";
        pdfDocument.Save(pdfFilePath);

        Console.WriteLine($"PDF file saved to {pdfFilePath}");
    }
}
