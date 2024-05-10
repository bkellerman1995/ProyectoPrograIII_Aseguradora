
namespace ProyectoPrograIII.Layers.UI.Procesos
{
    partial class frmProcesosFacturacion
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
            this.lblNoFactura = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPoliza = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbPoliza = new System.Windows.Forms.ComboBox();
            this.btnAnnadirTarjeta = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mskCVC = new System.Windows.Forms.MaskedTextBox();
            this.mskNoTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.lblfechaExpiracion = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNoTarjeta = new System.Windows.Forms.Label();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.txtTipoPlan = new System.Windows.Forms.TextBox();
            this.lstCoberturas = new System.Windows.Forms.ListBox();
            this.lstFamiliares = new System.Windows.Forms.ListBox();
            this.lblListaFamiliares = new System.Windows.Forms.Label();
            this.lblListaCoberturas = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblTotalColones = new System.Windows.Forms.Label();
            this.lblTotalDolares = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.txtFechaExpiracion = new System.Windows.Forms.TextBox();
            this.txtTotalColones = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarFirma = new System.Windows.Forms.Button();
            this.picSignature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFactura.Location = new System.Drawing.Point(23, 106);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(203, 46);
            this.lblNoFactura.TabIndex = 0;
            this.lblNoFactura.Text = "No. Factura";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Enabled = false;
            this.txtNoFactura.Location = new System.Drawing.Point(265, 106);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(405, 51);
            this.txtNoFactura.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(28, 322);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(131, 46);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblPoliza
            // 
            this.lblPoliza.AutoSize = true;
            this.lblPoliza.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliza.Location = new System.Drawing.Point(23, 208);
            this.lblPoliza.Name = "lblPoliza";
            this.lblPoliza.Size = new System.Drawing.Size(115, 46);
            this.lblPoliza.TabIndex = 3;
            this.lblPoliza.Text = "Poliza";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(265, 316);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(854, 51);
            this.txtCliente.TabIndex = 5;
            // 
            // cmbPoliza
            // 
            this.cmbPoliza.FormattingEnabled = true;
            this.cmbPoliza.Location = new System.Drawing.Point(265, 219);
            this.cmbPoliza.Name = "cmbPoliza";
            this.cmbPoliza.Size = new System.Drawing.Size(854, 53);
            this.cmbPoliza.TabIndex = 7;
            this.cmbPoliza.SelectedIndexChanged += new System.EventHandler(this.cmbPoliza_SelectedIndexChanged);
            // 
            // btnAnnadirTarjeta
            // 
            this.btnAnnadirTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirTarjeta.Location = new System.Drawing.Point(12, 1010);
            this.btnAnnadirTarjeta.Name = "btnAnnadirTarjeta";
            this.btnAnnadirTarjeta.Size = new System.Drawing.Size(354, 135);
            this.btnAnnadirTarjeta.TabIndex = 8;
            this.btnAnnadirTarjeta.Text = "Añadir tarjeta";
            this.btnAnnadirTarjeta.UseVisualStyleBackColor = true;
            this.btnAnnadirTarjeta.Click += new System.EventHandler(this.btnAnnadirTarjeta_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(1109, 1087);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(374, 51);
            this.txtDescripcion.TabIndex = 22;
            // 
            // mskCVC
            // 
            this.mskCVC.Enabled = false;
            this.mskCVC.Location = new System.Drawing.Point(1106, 1186);
            this.mskCVC.Mask = "999";
            this.mskCVC.Name = "mskCVC";
            this.mskCVC.Size = new System.Drawing.Size(377, 51);
            this.mskCVC.TabIndex = 20;
            // 
            // mskNoTarjeta
            // 
            this.mskNoTarjeta.Enabled = false;
            this.mskNoTarjeta.Location = new System.Drawing.Point(1106, 1003);
            this.mskNoTarjeta.Mask = "9999999999999999";
            this.mskNoTarjeta.Name = "mskNoTarjeta";
            this.mskNoTarjeta.Size = new System.Drawing.Size(377, 51);
            this.mskNoTarjeta.TabIndex = 19;
            // 
            // lblfechaExpiracion
            // 
            this.lblfechaExpiracion.AutoSize = true;
            this.lblfechaExpiracion.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaExpiracion.Location = new System.Drawing.Point(420, 1274);
            this.lblfechaExpiracion.Name = "lblfechaExpiracion";
            this.lblfechaExpiracion.Size = new System.Drawing.Size(335, 46);
            this.lblfechaExpiracion.TabIndex = 18;
            this.lblfechaExpiracion.Text = "Fecha de expiración";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.Location = new System.Drawing.Point(420, 1181);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(84, 46);
            this.lblCVC.TabIndex = 17;
            this.lblCVC.Text = "CVC";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(420, 1099);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(207, 46);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNoTarjeta
            // 
            this.lblNoTarjeta.AutoSize = true;
            this.lblNoTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTarjeta.Location = new System.Drawing.Point(420, 1009);
            this.lblNoTarjeta.Name = "lblNoTarjeta";
            this.lblNoTarjeta.Size = new System.Drawing.Size(194, 46);
            this.lblNoTarjeta.TabIndex = 15;
            this.lblNoTarjeta.Text = "No. Tarjeta";
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(28, 404);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(162, 46);
            this.lblTipoPlan.TabIndex = 23;
            this.lblTipoPlan.Text = "TipoPlan";
            // 
            // txtTipoPlan
            // 
            this.txtTipoPlan.Enabled = false;
            this.txtTipoPlan.Location = new System.Drawing.Point(265, 404);
            this.txtTipoPlan.Name = "txtTipoPlan";
            this.txtTipoPlan.Size = new System.Drawing.Size(854, 51);
            this.txtTipoPlan.TabIndex = 24;
            // 
            // lstCoberturas
            // 
            this.lstCoberturas.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCoberturas.FormattingEnabled = true;
            this.lstCoberturas.ItemHeight = 45;
            this.lstCoberturas.Location = new System.Drawing.Point(671, 579);
            this.lstCoberturas.Name = "lstCoberturas";
            this.lstCoberturas.Size = new System.Drawing.Size(907, 409);
            this.lstCoberturas.TabIndex = 25;
            this.lstCoberturas.SelectedIndexChanged += new System.EventHandler(this.lstCoberturas_SelectedIndexChanged);
            // 
            // lstFamiliares
            // 
            this.lstFamiliares.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFamiliares.FormattingEnabled = true;
            this.lstFamiliares.ItemHeight = 45;
            this.lstFamiliares.Location = new System.Drawing.Point(31, 579);
            this.lstFamiliares.Name = "lstFamiliares";
            this.lstFamiliares.Size = new System.Drawing.Size(615, 409);
            this.lstFamiliares.TabIndex = 26;
            this.lstFamiliares.SelectedIndexChanged += new System.EventHandler(this.lstFamiliares_SelectedIndexChanged);
            // 
            // lblListaFamiliares
            // 
            this.lblListaFamiliares.AutoSize = true;
            this.lblListaFamiliares.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaFamiliares.Location = new System.Drawing.Point(23, 510);
            this.lblListaFamiliares.Name = "lblListaFamiliares";
            this.lblListaFamiliares.Size = new System.Drawing.Size(311, 46);
            this.lblListaFamiliares.TabIndex = 27;
            this.lblListaFamiliares.Text = "Lista de Familiares";
            // 
            // lblListaCoberturas
            // 
            this.lblListaCoberturas.AutoSize = true;
            this.lblListaCoberturas.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCoberturas.Location = new System.Drawing.Point(740, 510);
            this.lblListaCoberturas.Name = "lblListaCoberturas";
            this.lblListaCoberturas.Size = new System.Drawing.Size(327, 46);
            this.lblListaCoberturas.TabIndex = 28;
            this.lblListaCoberturas.Text = "Lista de Coberturas";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(34, 1404);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(76, 46);
            this.lblIVA.TabIndex = 30;
            this.lblIVA.Text = "IVA";
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(153, 1404);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(250, 51);
            this.txtIVA.TabIndex = 31;
            // 
            // lblTotalColones
            // 
            this.lblTotalColones.AutoSize = true;
            this.lblTotalColones.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalColones.Location = new System.Drawing.Point(34, 1530);
            this.lblTotalColones.Name = "lblTotalColones";
            this.lblTotalColones.Size = new System.Drawing.Size(235, 46);
            this.lblTotalColones.TabIndex = 32;
            this.lblTotalColones.Text = "Total Colones";
            // 
            // lblTotalDolares
            // 
            this.lblTotalDolares.AutoSize = true;
            this.lblTotalDolares.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDolares.Location = new System.Drawing.Point(31, 1617);
            this.lblTotalDolares.Name = "lblTotalDolares";
            this.lblTotalDolares.Size = new System.Drawing.Size(238, 46);
            this.lblTotalDolares.TabIndex = 33;
            this.lblTotalDolares.Text = "Total Dólares ";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.Location = new System.Drawing.Point(769, 106);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(109, 46);
            this.lblTipoCambio.TabIndex = 34;
            this.lblTipoCambio.Text = "label1";
            // 
            // txtFechaExpiracion
            // 
            this.txtFechaExpiracion.Enabled = false;
            this.txtFechaExpiracion.Location = new System.Drawing.Point(1109, 1268);
            this.txtFechaExpiracion.Name = "txtFechaExpiracion";
            this.txtFechaExpiracion.Size = new System.Drawing.Size(374, 51);
            this.txtFechaExpiracion.TabIndex = 36;
            // 
            // txtTotalColones
            // 
            this.txtTotalColones.Enabled = false;
            this.txtTotalColones.Location = new System.Drawing.Point(274, 1527);
            this.txtTotalColones.Name = "txtTotalColones";
            this.txtTotalColones.Size = new System.Drawing.Size(235, 51);
            this.txtTotalColones.TabIndex = 37;
            // 
            // txtDolares
            // 
            this.txtDolares.Enabled = false;
            this.txtDolares.Location = new System.Drawing.Point(274, 1612);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(235, 51);
            this.txtDolares.TabIndex = 38;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Enabled = false;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerarFactura.Location = new System.Drawing.Point(20, 1789);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(315, 171);
            this.btnGenerarFactura.TabIndex = 39;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(1283, 1809);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(315, 171);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarFirma
            // 
            this.btnBorrarFirma.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFirma.Location = new System.Drawing.Point(592, 1742);
            this.btnBorrarFirma.Name = "btnBorrarFirma";
            this.btnBorrarFirma.Size = new System.Drawing.Size(354, 92);
            this.btnBorrarFirma.TabIndex = 43;
            this.btnBorrarFirma.Text = "Borrar Firma";
            this.btnBorrarFirma.UseVisualStyleBackColor = true;
            this.btnBorrarFirma.Click += new System.EventHandler(this.btnBorrarFirma_Click);
            // 
            // picSignature
            // 
            this.picSignature.BackColor = System.Drawing.Color.White;
            this.picSignature.Enabled = false;
            this.picSignature.Location = new System.Drawing.Point(592, 1389);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(974, 329);
            this.picSignature.TabIndex = 42;
            this.picSignature.TabStop = false;
            this.picSignature.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSignature_MouseDown);
            this.picSignature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSignature_MouseMove);
            this.picSignature.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSignature_MouseUp);
            // 
            // frmProcesosFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1610, 2120);
            this.Controls.Add(this.btnBorrarFirma);
            this.Controls.Add(this.picSignature);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtTotalColones);
            this.Controls.Add(this.txtFechaExpiracion);
            this.Controls.Add(this.lblTipoCambio);
            this.Controls.Add(this.lblTotalDolares);
            this.Controls.Add(this.lblTotalColones);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblListaCoberturas);
            this.Controls.Add(this.lblListaFamiliares);
            this.Controls.Add(this.lstFamiliares);
            this.Controls.Add(this.lstCoberturas);
            this.Controls.Add(this.txtTipoPlan);
            this.Controls.Add(this.lblTipoPlan);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.mskCVC);
            this.Controls.Add(this.mskNoTarjeta);
            this.Controls.Add(this.lblfechaExpiracion);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNoTarjeta);
            this.Controls.Add(this.btnAnnadirTarjeta);
            this.Controls.Add(this.cmbPoliza);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblPoliza);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.lblNoFactura);
            this.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProcesosFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmProcesosFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPoliza;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbPoliza;
        private System.Windows.Forms.Button btnAnnadirTarjeta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox mskCVC;
        private System.Windows.Forms.MaskedTextBox mskNoTarjeta;
        private System.Windows.Forms.Label lblfechaExpiracion;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNoTarjeta;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.TextBox txtTipoPlan;
        private System.Windows.Forms.ListBox lstCoberturas;
        private System.Windows.Forms.ListBox lstFamiliares;
        private System.Windows.Forms.Label lblListaFamiliares;
        private System.Windows.Forms.Label lblListaCoberturas;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label lblTotalColones;
        private System.Windows.Forms.Label lblTotalDolares;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.TextBox txtFechaExpiracion;
        private System.Windows.Forms.TextBox txtTotalColones;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picSignature;
        private System.Windows.Forms.Button btnBorrarFirma;
    }
}