
namespace ProyectoPrograIII.Layers.UI.Reportes
{
    partial class frmReporteVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspSELECTFechaEncabezadoByFechaFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReporteVentasPoliza = new ProyectoPrograIII.DataSetReporteVentasPoliza();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter = new ProyectoPrograIII.DataSetReporteVentasPolizaTableAdapters.usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELECTFechaEncabezadoByFechaFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteVentasPoliza)).BeginInit();
            this.SuspendLayout();
            // 
            // uspSELECTFechaEncabezadoByFechaFacturacionBindingSource
            // 
            this.uspSELECTFechaEncabezadoByFechaFacturacionBindingSource.DataMember = "usp_SELECT_FechaEncabezado_ByFechaFacturacion";
            this.uspSELECTFechaEncabezadoByFechaFacturacionBindingSource.DataSource = this.dataSetReporteVentasPoliza;
            // 
            // dataSetReporteVentasPoliza
            // 
            this.dataSetReporteVentasPoliza.DataSetName = "DataSetReporteVentasPoliza";
            this.dataSetReporteVentasPoliza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetReporteVentas";
            reportDataSource2.Value = this.uspSELECTFechaEncabezadoByFechaFacturacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPrograIII.Layers.UI.Reportes.reporteVentasPorRangoFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 64);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 675);
            this.reportViewer1.TabIndex = 1;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(25, 42);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerFechaInicio.TabIndex = 2;
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(285, 42);
            this.dateTimePickerFechaFinal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerFechaFinal.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(34, 16);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(107, 20);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(294, 16);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(103, 20);
            this.lblFechaFinal.TabIndex = 5;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(548, 37);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(190, 25);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter
            // 
            this.usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(998, 376);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dateTimePickerFechaFinal);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas ";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspSELECTFechaEncabezadoByFechaFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteVentasPoliza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.BindingSource uspSELECTFechaEncabezadoByFechaFacturacionBindingSource;
        private DataSetReporteVentasPoliza dataSetReporteVentasPoliza;
        private DataSetReporteVentasPolizaTableAdapters.usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter usp_SELECT_FechaEncabezado_ByFechaFacturacionTableAdapter;
    }
}