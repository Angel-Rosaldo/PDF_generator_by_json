using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using ReportesAPI.Reports;
using System.IO;

[ApiController]
[Route("api/reportes")]
public class TestReportController : ControllerBase
{
    [HttpGet("test-pdf")]
    public IActionResult GenerarPDFTest()
    {
        try
        {
            XtraReport1 reporte = new XtraReport1();
            reporte.ExportToPdf("C:/Users/angel/Desktop/TestPDF.pdf");

            return Ok("PDF de prueba generado correctamente en: C:/Users/angel/Desktop/TestPDF.pdf");
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al generar el PDF de prueba: {ex.Message}");
        }
    }
}
