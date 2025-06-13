using System;
using System.Text.Json;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;

namespace ReportesAPI.Reports
{
    public partial class XtraReport1 : XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            ConfigurarParametros();
        }

        private void ConfigurarParametros()
        {
            Parameters.Add(new Parameter() { Name = "ContractNumber", Type = typeof(string), Visible = false });
            Parameters.Add(new Parameter() { Name = "ClientName", Type = typeof(string), Visible = false });
            Parameters.Add(new Parameter() { Name = "TotalAmount", Type = typeof(decimal), Visible = false });
            Parameters.Add(new Parameter() { Name = "StartDate", Type = typeof(string), Visible = false });
            Parameters.Add(new Parameter() { Name = "EndDate", Type = typeof(string), Visible = false });
        }

        public void ConfigurarDatos(JsonElement contratoJson)
        {
            try
            {
                Parameters["ContractNumber"].Value = contratoJson.GetProperty("contractNumber").GetString();
                Parameters["ClientName"].Value = $"{contratoJson.GetProperty("client").GetProperty("firstName").GetString()} {contratoJson.GetProperty("client").GetProperty("lastName").GetString()}";
                Parameters["TotalAmount"].Value = contratoJson.GetProperty("totalAmount").GetDecimal();
                Parameters["StartDate"].Value = contratoJson.GetProperty("startDate").GetString();
                Parameters["EndDate"].Value = contratoJson.GetProperty("endDate").GetString();

                var contratoData = new List<dynamic>
                {
                    new {
                        ContractNumber = Parameters["ContractNumber"].Value,
                        ClientName = Parameters["ClientName"].Value,
                        TotalAmount = Parameters["TotalAmount"].Value,
                        StartDate = Parameters["StartDate"].Value,
                        EndDate = Parameters["EndDate"].Value
                    }
                };

                DataSource = contratoData;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar los datos del JSON en el reporte: {ex.Message}");
            }
        }
    }
}
