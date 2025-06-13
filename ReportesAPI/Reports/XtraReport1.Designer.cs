namespace ReportesAPI.Reports
{
    partial class XtraReport1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            // 🔹 Etiqueta para mostrar el número de contrato
            DevExpress.XtraReports.UI.XRLabel lblContractNumber = new DevExpress.XtraReports.UI.XRLabel();
            lblContractNumber.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContractNumber]"));
            lblContractNumber.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            lblContractNumber.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.Detail.Controls.Add(lblContractNumber);

            // 🔹 Etiqueta para mostrar el nombre del cliente
            DevExpress.XtraReports.UI.XRLabel lblClientName = new DevExpress.XtraReports.UI.XRLabel();
            lblClientName.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ClientName]"));
            lblClientName.LocationFloat = new DevExpress.Utils.PointFloat(10F, 40F);
            lblClientName.SizeF = new System.Drawing.SizeF(300F, 25F);
            this.Detail.Controls.Add(lblClientName);

            // 🔹 Etiqueta para mostrar el monto total
            DevExpress.XtraReports.UI.XRLabel lblTotalAmount = new DevExpress.XtraReports.UI.XRLabel();
            lblTotalAmount.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]"));
            lblTotalAmount.LocationFloat = new DevExpress.Utils.PointFloat(10F, 70F);
            lblTotalAmount.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.Detail.Controls.Add(lblTotalAmount);

            // 🔹 Etiqueta para mostrar la fecha de inicio
            DevExpress.XtraReports.UI.XRLabel lblStartDate = new DevExpress.XtraReports.UI.XRLabel();
            lblStartDate.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StartDate]"));
            lblStartDate.LocationFloat = new DevExpress.Utils.PointFloat(10F, 100F);
            lblStartDate.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.Detail.Controls.Add(lblStartDate);

            // 🔹 Etiqueta para mostrar la fecha de finalización
            DevExpress.XtraReports.UI.XRLabel lblEndDate = new DevExpress.XtraReports.UI.XRLabel();
            lblEndDate.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EndDate]"));
            lblEndDate.LocationFloat = new DevExpress.Utils.PointFloat(10F, 130F);
            lblEndDate.SizeF = new System.Drawing.SizeF(200F, 25F);
            this.Detail.Controls.Add(lblEndDate);

            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.TopMargin,
                this.BottomMargin,
                this.Detail
            });

            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "24.2";

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
    }
}
