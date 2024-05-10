
namespace ProyectoPrograIII.Layers.UI.Reportes
{
    partial class frmReportesPoliza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usp_SELECT_Poliza_ByClienteIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPolizaCliente = new ProyectoPrograIII.DataSetPolizaCliente();
            this.uspSELECTPolizaByClienteIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPolizas = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_SELECT_Poliza_ByClienteIDTableAdapter = new ProyectoPrograIII.DataSetPolizaClienteTableAdapters.usp_SELECT_Poliza_ByClienteIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usp_SELECT_Poliza_ByClienteIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPolizaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELECTPolizaByClienteIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usp_SELECT_Poliza_ByClienteIDBindingSource
            // 
            this.usp_SELECT_Poliza_ByClienteIDBindingSource.DataMember = "usp_SELECT_Poliza_ByClienteID";
            this.usp_SELECT_Poliza_ByClienteIDBindingSource.DataSource = this.dataSetPolizaCliente;
            // 
            // dataSetPolizaCliente
            // 
            this.dataSetPolizaCliente.DataSetName = "DataSetPolizaCliente";
            this.dataSetPolizaCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspSELECTPolizaByClienteIDBindingSource
            // 
            this.uspSELECTPolizaByClienteIDBindingSource.DataMember = "usp_SELECT_Poliza_ByClienteID";
            this.uspSELECTPolizaByClienteIDBindingSource.DataSource = this.dataSetPolizaCliente;
            // 
            // cmbPolizas
            // 
            this.cmbPolizas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPolizas.FormattingEnabled = true;
            this.cmbPolizas.Location = new System.Drawing.Point(154, 6);
            this.cmbPolizas.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbPolizas.Name = "cmbPolizas";
            this.cmbPolizas.Size = new System.Drawing.Size(309, 29);
            this.cmbPolizas.TabIndex = 1;
            this.cmbPolizas.SelectedIndexChanged += new System.EventHandler(this.cmbPolizas_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPoliza";
            reportDataSource1.Value = this.usp_SELECT_Poliza_ByClienteIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPrograIII.Layers.UI.Reportes.reportePolIndividual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 86);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_SELECT_Poliza_ByClienteIDTableAdapter
            // 
            this.usp_SELECT_Poliza_ByClienteIDTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportesPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 376);
            this.Controls.Add(this.cmbPolizas);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmReportesPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Polizas";
            this.Load += new System.EventHandler(this.frmReportesPoliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_SELECT_Poliza_ByClienteIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPolizaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELECTPolizaByClienteIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPolizas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspSELECTPolizaByClienteIDBindingSource;
        private DataSetPolizaCliente dataSetPolizaCliente;
        private DataSetPolizaClienteTableAdapters.usp_SELECT_Poliza_ByClienteIDTableAdapter usp_SELECT_Poliza_ByClienteIDTableAdapter;
        private System.Windows.Forms.BindingSource usp_SELECT_Poliza_ByClienteIDBindingSource;
    }
}