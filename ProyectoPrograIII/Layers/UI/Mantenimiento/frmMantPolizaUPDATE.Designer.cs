
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantPolizaUPDATE
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
            this.btnGenerarPlanes = new System.Windows.Forms.Button();
            this.btnAnnadirFamiliar = new System.Windows.Forms.Button();
            this.lstCoberturas = new System.Windows.Forms.ListBox();
            this.lblCoberturasPlan = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbTipoPlan = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnGenerarPlanes
            // 
            this.btnGenerarPlanes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPlanes.Location = new System.Drawing.Point(12, 313);
            this.btnGenerarPlanes.Name = "btnGenerarPlanes";
            this.btnGenerarPlanes.Size = new System.Drawing.Size(438, 67);
            this.btnGenerarPlanes.TabIndex = 130;
            this.btnGenerarPlanes.Text = "Generar Planes";
            this.btnGenerarPlanes.UseVisualStyleBackColor = true;
            this.btnGenerarPlanes.Click += new System.EventHandler(this.btnGenerarPlanes_Click);
            // 
            // btnAnnadirFamiliar
            // 
            this.btnAnnadirFamiliar.Enabled = false;
            this.btnAnnadirFamiliar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirFamiliar.Location = new System.Drawing.Point(2, 554);
            this.btnAnnadirFamiliar.Name = "btnAnnadirFamiliar";
            this.btnAnnadirFamiliar.Size = new System.Drawing.Size(475, 84);
            this.btnAnnadirFamiliar.TabIndex = 129;
            this.btnAnnadirFamiliar.Text = "Añadir Familiares";
            this.btnAnnadirFamiliar.UseVisualStyleBackColor = true;
            this.btnAnnadirFamiliar.Click += new System.EventHandler(this.btnAnnadirFamiliar_Click);
            // 
            // lstCoberturas
            // 
            this.lstCoberturas.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCoberturas.FormattingEnabled = true;
            this.lstCoberturas.ItemHeight = 45;
            this.lstCoberturas.Location = new System.Drawing.Point(12, 765);
            this.lstCoberturas.Name = "lstCoberturas";
            this.lstCoberturas.Size = new System.Drawing.Size(1306, 499);
            this.lstCoberturas.TabIndex = 128;
            // 
            // lblCoberturasPlan
            // 
            this.lblCoberturasPlan.AutoSize = true;
            this.lblCoberturasPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoberturasPlan.Location = new System.Drawing.Point(9, 684);
            this.lblCoberturasPlan.Name = "lblCoberturasPlan";
            this.lblCoberturasPlan.Size = new System.Drawing.Size(388, 54);
            this.lblCoberturasPlan.TabIndex = 127;
            this.lblCoberturasPlan.Text = "Lista de Coberturas";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(260, 212);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(790, 46);
            this.cmbCliente.TabIndex = 126;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(20, 203);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(154, 54);
            this.lblCliente.TabIndex = 125;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbTipoPlan
            // 
            this.cmbTipoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPlan.FormattingEnabled = true;
            this.cmbTipoPlan.Location = new System.Drawing.Point(319, 433);
            this.cmbTipoPlan.Name = "cmbTipoPlan";
            this.cmbTipoPlan.Size = new System.Drawing.Size(958, 46);
            this.cmbTipoPlan.TabIndex = 124;
            this.cmbTipoPlan.SelectedValueChanged += new System.EventHandler(this.cmbTipoPlan_SelectedValueChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(20, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 54);
            this.lblID.TabIndex = 122;
            this.lblID.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(937, 1412);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(364, 196);
            this.btnCancelar.TabIndex = 121;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Location = new System.Drawing.Point(12, 1393);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(383, 196);
            this.btnActualizar.TabIndex = 120;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(456, 124);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(593, 45);
            this.txtDescripcion.TabIndex = 119;
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(12, 424);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(257, 54);
            this.lblTipoPlan.TabIndex = 118;
            this.lblTipoPlan.Text = "Tipo de Plan";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(242, 54);
            this.lblDescripcion.TabIndex = 117;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // mskID
            // 
            this.mskID.Enabled = false;
            this.mskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskID.Location = new System.Drawing.Point(393, 39);
            this.mskID.Mask = "AAA";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(656, 45);
            this.mskID.TabIndex = 131;
            // 
            // frmMantPolizaUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1330, 1619);
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
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTipoPlan);
            this.Controls.Add(this.lblDescripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMantPolizaUPDATE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Poliza";
            this.Load += new System.EventHandler(this.frmMantPolizaUPDATE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPlanes;
        private System.Windows.Forms.Button btnAnnadirFamiliar;
        private System.Windows.Forms.ListBox lstCoberturas;
        private System.Windows.Forms.Label lblCoberturasPlan;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbTipoPlan;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.MaskedTextBox mskID;
    }
}