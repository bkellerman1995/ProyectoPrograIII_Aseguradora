
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantPlanesUPDATES
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
            this.lstCobertura = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstCoberturaPlan = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.chcFamiliar = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCoberturaPlan = new System.Windows.Forms.Label();
            this.lblCoberturas = new System.Windows.Forms.Label();
            this.mskCosto = new System.Windows.Forms.MaskedTextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCobertura
            // 
            this.lstCobertura.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCobertura.FormattingEnabled = true;
            this.lstCobertura.ItemHeight = 45;
            this.lstCobertura.Location = new System.Drawing.Point(1363, 576);
            this.lstCobertura.Name = "lstCobertura";
            this.lstCobertura.Size = new System.Drawing.Size(1168, 814);
            this.lstCobertura.TabIndex = 27;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::ProyectoPrograIII.Properties.Resources.delete3;
            this.btnQuitar.Location = new System.Drawing.Point(962, 975);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(378, 215);
            this.btnQuitar.TabIndex = 26;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ProyectoPrograIII.Properties.Resources.create;
            this.btnAgregar.Location = new System.Drawing.Point(952, 599);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(388, 220);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCoberturaPlan
            // 
            this.lstCoberturaPlan.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCoberturaPlan.FormattingEnabled = true;
            this.lstCoberturaPlan.ItemHeight = 45;
            this.lstCoberturaPlan.Location = new System.Drawing.Point(35, 552);
            this.lstCoberturaPlan.Name = "lstCoberturaPlan";
            this.lstCoberturaPlan.Size = new System.Drawing.Size(883, 814);
            this.lstCoberturaPlan.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(2131, 1532);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(420, 159);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(211, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(558, 53);
            this.txtNombre.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(498, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 53);
            this.txtID.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 54);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(26, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 54);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // chcFamiliar
            // 
            this.chcFamiliar.AutoSize = true;
            this.chcFamiliar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcFamiliar.Location = new System.Drawing.Point(30, 332);
            this.chcFamiliar.Name = "chcFamiliar";
            this.chcFamiliar.Size = new System.Drawing.Size(211, 58);
            this.chcFamiliar.TabIndex = 28;
            this.chcFamiliar.Text = "Familiar";
            this.chcFamiliar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Location = new System.Drawing.Point(952, 23);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(439, 175);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCoberturaPlan
            // 
            this.lblCoberturaPlan.AutoSize = true;
            this.lblCoberturaPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoberturaPlan.Location = new System.Drawing.Point(26, 455);
            this.lblCoberturaPlan.Name = "lblCoberturaPlan";
            this.lblCoberturaPlan.Size = new System.Drawing.Size(394, 54);
            this.lblCoberturaPlan.TabIndex = 30;
            this.lblCoberturaPlan.Text = "Coberturas del plan";
            // 
            // lblCoberturas
            // 
            this.lblCoberturas.AutoSize = true;
            this.lblCoberturas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoberturas.Location = new System.Drawing.Point(1236, 455);
            this.lblCoberturas.Name = "lblCoberturas";
            this.lblCoberturas.Size = new System.Drawing.Size(457, 54);
            this.lblCoberturas.TabIndex = 31;
            this.lblCoberturas.Text = "Coberturas disponibles";
            // 
            // mskCosto
            // 
            this.mskCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCosto.Location = new System.Drawing.Point(498, 239);
            this.mskCosto.Mask = "999";
            this.mskCosto.Name = "mskCosto";
            this.mskCosto.Size = new System.Drawing.Size(271, 53);
            this.mskCosto.TabIndex = 33;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(26, 225);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(194, 54);
            this.lblCosto.TabIndex = 32;
            this.lblCosto.Text = "Costo ($)";
            // 
            // frmMantPlanesUPDATES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2577, 1703);
            this.Controls.Add(this.mskCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblCoberturas);
            this.Controls.Add(this.lblCoberturaPlan);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.chcFamiliar);
            this.Controls.Add(this.lstCobertura);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstCoberturaPlan);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMantPlanesUPDATES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Planes";
            this.Load += new System.EventHandler(this.frmMantPlanesUPDATES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCobertura;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCoberturaPlan;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox chcFamiliar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCoberturaPlan;
        private System.Windows.Forms.Label lblCoberturas;
        private System.Windows.Forms.MaskedTextBox mskCosto;
        private System.Windows.Forms.Label lblCosto;
    }
}