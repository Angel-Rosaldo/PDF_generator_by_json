using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

[ApiController]
[Route("api/reportes")]
public class TestReportDataController : ControllerBase
{
    [HttpPost("test-data")]
    public IActionResult RecibirJSON([FromBody] JsonElement contratoJson)
    {
        try
        {
            // 🔹 Imprimir datos en consola
            Console.WriteLine("JSON recibido: " + contratoJson.GetRawText());
            Console.WriteLine("ContractNumber: " + contratoJson.GetProperty("contractNumber").GetString());
            Console.WriteLine("ClientName: " + contratoJson.GetProperty("client").GetProperty("firstName").GetString()
                + " " + contratoJson.GetProperty("client").GetProperty("lastName").GetString());
            Console.WriteLine("TotalAmount: " + contratoJson.GetProperty("totalAmount").GetDecimal());
            Console.WriteLine("StartDate: " + contratoJson.GetProperty("startDate").GetString());
            Console.WriteLine("EndDate: " + contratoJson.GetProperty("endDate").GetString());

            return Ok("Datos procesados correctamente. Revisa la consola para verificar.");
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al procesar JSON: {ex.Message}");
        }
    }
}
