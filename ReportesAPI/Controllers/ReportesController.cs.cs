using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using ReportesAPI.Reports;
using System.IO;
using System.Text.Json;

[ApiController]
[Route("api/reportes")]
public class ReportesController : ControllerBase
{
    [HttpPost("generar-pdf")]
    public IActionResult GenerarPDF([FromBody] JsonElement contratoJson)
    {
        try
        {
            Console.WriteLine("JSON recibido: " + contratoJson.GetRawText());

            XtraReport1 reporte = new XtraReport1();
            reporte.ConfigurarDatos(contratoJson);

            using (MemoryStream ms = new MemoryStream())
            {
                if (reporte.DataSource == null || reporte.Parameters["ContractNumber"].Value == null)
                {
                    return BadRequest("Error: El reporte no tiene datos asignados correctamente.");
                }

                reporte.ExportToPdf(ms);
                ms.Position = 0;

                string rutaTemporal = "C:/Users/angel/Desktop/ContratoDebug.pdf";
                System.IO.File.WriteAllBytes(rutaTemporal, ms.ToArray());
                Console.WriteLine($"PDF guardado en: {rutaTemporal}");

                return File(ms.ToArray(), "application/pdf", "Contrato.pdf");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al generar el PDF: {ex.Message}");
            return BadRequest($"Error al generar el PDF: {ex.Message}");
        }
    }
}
