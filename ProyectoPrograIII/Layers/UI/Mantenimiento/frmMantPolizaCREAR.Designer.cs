
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantPolizaCREAR
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbTipoPlan = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCoberturasPlan = new System.Windows.Forms.Label();
            this.lstCoberturas = new System.Windows.Forms.ListBox();
            this.btnAnnadirFamiliar = new System.Windows.Forms.Button();
            this.btnGenerarPlanes = new System.Windows.Forms.Button();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(22, 35);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 54);
            this.lblID.TabIndex = 107;
            this.lblID.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(645, 1462);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(313, 163);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Enabled = false;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrear.Location = new System.Drawing.Point(11, 1462);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(348, 163);
            this.btnCrear.TabIndex = 103;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(354, 118);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(585, 53);
            this.txtDescripcion.TabIndex = 100;
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(11, 481);
            this.lblTipoPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(257, 54);
            this.lblTipoPlan.TabIndex = 99;
            this.lblTipoPlan.Text = "Tipo de Plan";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(22, 118);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(242, 54);
            this.lblDescripcion.TabIndex = 97;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cmbTipoPlan
            // 
            this.cmbTipoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPlan.FormattingEnabled = true;
            this.cmbTipoPlan.Location = new System.Drawing.Point(272, 484);
            this.cmbTipoPlan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPlan.Name = "cmbTipoPlan";
            this.cmbTipoPlan.Size = new System.Drawing.Size(865, 44);
            this.cmbTipoPlan.TabIndex = 109;
            this.cmbTipoPlan.SelectedValueChanged += new System.EventHandler(this.cmbTipoPlan_SelectedValueChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(22, 205);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(154, 54);
            this.lblCliente.TabIndex = 110;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(207, 205);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(732, 54);
            this.cmbCliente.TabIndex = 111;
            // 
            // lblCoberturasPlan
            // 
            this.lblCoberturasPlan.AutoSize = true;
            this.lblCoberturasPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoberturasPlan.Location = new System.Drawing.Point(11, 794);
            this.lblCoberturasPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoberturasPlan.Name = "lblCoberturasPlan";
            this.lblCoberturasPlan.Size = new System.Drawing.Size(388, 54);
            this.lblCoberturasPlan.TabIndex = 113;
            this.lblCoberturasPlan.Text = "Lista de Coberturas";
            // 
            // lstCoberturas
            // 
            this.lstCoberturas.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCoberturas.FormattingEnabled = true;
            this.lstCoberturas.ItemHeight = 45;
            this.lstCoberturas.Location = new System.Drawing.Point(11, 901);
            this.lstCoberturas.Margin = new System.Windows.Forms.Padding(2);
            this.lstCoberturas.Name = "lstCoberturas";
            this.lstCoberturas.Size = new System.Drawing.Size(1114, 454);
            this.lstCoberturas.TabIndex = 114;
            // 
            // btnAnnadirFamiliar
            // 
            this.btnAnnadirFamiliar.Enabled = false;
            this.btnAnnadirFamiliar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirFamiliar.Location = new System.Drawing.Point(11, 636);
            this.btnAnnadirFamiliar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnadirFamiliar.Name = "btnAnnadirFamiliar";
            this.btnAnnadirFamiliar.Size = new System.Drawing.Size(478, 85);
            this.btnAnnadirFamiliar.TabIndex = 115;
            this.btnAnnadirFamiliar.Text = "Añadir Familiares";
            this.btnAnnadirFamiliar.UseVisualStyleBackColor = true;
            this.btnAnnadirFamiliar.Click += new System.EventHandler(this.btnAnnadirFamiliar_Click);
            // 
            // btnGenerarPlanes
            // 
            this.btnGenerarPlanes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPlanes.Location = new System.Drawing.Point(527, 335);
            this.btnGenerarPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarPlanes.Name = "btnGenerarPlanes";
            this.btnGenerarPlanes.Size = new System.Drawing.Size(412, 68);
            this.btnGenerarPlanes.TabIndex = 116;
            this.btnGenerarPlanes.Text = "Generar Planes";
            this.btnGenerarPlanes.UseVisualStyleBackColor = true;
            this.btnGenerarPlanes.Click += new System.EventHandler(this.btnGenerarPlanes_Click);
            // 
            // mskID
            // 
            this.mskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskID.Location = new System.Drawing.Point(746, 35);
            this.mskID.Mask = "AAA";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(193, 53);
            this.mskID.TabIndex = 117;
            // 
            // frmMantPolizaCREAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1161, 1687);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.btnGenerarPlanes);
            this.Controls.Add(this.btnAnnadirFamiliar);
            this.Controls.Add(this.lstCoberturas);
            this.Controls.Add(this.lblCoberturasPlan);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbTipoPlan);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTipoPlan);
            this.Controls.Add(this.lblDescripcion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMantPolizaCREAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Poliza";
            this.Load += new System.EventHandler(this.frmMantPolizaCREAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbTipoPlan;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCoberturasPlan;
        private System.Windows.Forms.ListBox lstCoberturas;
        private System.Windows.Forms.Button btnAnnadirFamiliar;
        private System.Windows.Forms.Button btnGenerarPlanes;
        private System.Windows.Forms.MaskedTextBox mskID;
    }
}