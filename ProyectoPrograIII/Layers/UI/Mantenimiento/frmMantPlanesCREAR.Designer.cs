
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantPlanesCREAR
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstCobertura = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lstCoberturaPlan = new System.Windows.Forms.ListBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.chcFamiliar = new System.Windows.Forms.CheckBox();
            this.lblCoberturas = new System.Windows.Forms.Label();
            this.lblCoberturasPlan = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.mskCosto = new System.Windows.Forms.MaskedTextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(256, 145);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(508, 53);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 142);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 54);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(58, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 54);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(2404, 1553);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(443, 141);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstCobertura
            // 
            this.lstCobertura.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCobertura.FormattingEnabled = true;
            this.lstCobertura.ItemHeight = 45;
            this.lstCobertura.Location = new System.Drawing.Point(44, 587);
            this.lstCobertura.Name = "lstCobertura";
            this.lstCobertura.Size = new System.Drawing.Size(1155, 634);
            this.lstCobertura.TabIndex = 15;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::ProyectoPrograIII.Properties.Resources.delete3;
            this.btnQuitar.Location = new System.Drawing.Point(1240, 987);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(416, 206);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lstCoberturaPlan
            // 
            this.lstCoberturaPlan.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCoberturaPlan.FormattingEnabled = true;
            this.lstCoberturaPlan.ItemHeight = 45;
            this.lstCoberturaPlan.Location = new System.Drawing.Point(1693, 587);
            this.lstCoberturaPlan.Name = "lstCoberturaPlan";
            this.lstCoberturaPlan.Size = new System.Drawing.Size(1154, 634);
            this.lstCoberturaPlan.TabIndex = 18;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrear.Location = new System.Drawing.Point(851, 35);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(555, 170);
            this.btnCrear.TabIndex = 19;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCheckPLan_Click);
            // 
            // chcFamiliar
            // 
            this.chcFamiliar.AutoSize = true;
            this.chcFamiliar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcFamiliar.Location = new System.Drawing.Point(56, 326);
            this.chcFamiliar.Name = "chcFamiliar";
            this.chcFamiliar.Size = new System.Drawing.Size(211, 58);
            this.chcFamiliar.TabIndex = 21;
            this.chcFamiliar.Text = "Familiar";
            this.chcFamiliar.UseVisualStyleBackColor = true;
            // 
            // lblCoberturas
            // 
            this.lblCoberturas.AutoSize = true;
            this.lblCoberturas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoberturas.Location = new System.Drawing.Point(58, 411);
            this.lblCoberturas.Name = "lblCoberturas";
            this.lblCoberturas.Size = new System.Drawing.Size(462, 54);
            this.lblCoberturas.TabIndex = 22;
            this.lblCoberturas.Text = "Coberturas Disponibles";
            // 
            // lblCoberturasPlan
            // 
            this.lblCoberturasPlan.AutoSize = true;
            this.lblCoberturasPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoberturasPlan.Location = new System.Drawing.Point(1405, 411);
            this.lblCoberturasPlan.Name = "lblCoberturasPlan";
            this.lblCoberturasPlan.Size = new System.Drawing.Size(394, 54);
            this.lblCoberturasPlan.TabIndex = 23;
            this.lblCoberturasPlan.Text = "Coberturas del plan";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(58, 232);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(194, 54);
            this.lblCosto.TabIndex = 24;
            this.lblCosto.Text = "Costo ($)";
            // 
            // mskCosto
            // 
            this.mskCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCosto.Location = new System.Drawing.Point(493, 235);
            this.mskCosto.Mask = "000";
            this.mskCosto.Name = "mskCosto";
            this.mskCosto.Size = new System.Drawing.Size(271, 53);
            this.mskCosto.TabIndex = 25;
            // 
            // mskID
            // 
            this.mskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskID.Location = new System.Drawing.Point(493, 52);
            this.mskID.Mask = "AAAAAAA";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(193, 53);
            this.mskID.TabIndex = 118;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ProyectoPrograIII.Properties.Resources.create;
            this.btnAgregar.Location = new System.Drawing.Point(1259, 613);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(381, 251);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMantPlanesCREAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2873, 1706);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.mskCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblCoberturasPlan);
            this.Controls.Add(this.lblCoberturas);
            this.Controls.Add(this.chcFamiliar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lstCoberturaPlan);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstCobertura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmMantPlanesCREAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Plan";
            this.Load += new System.EventHandler(this.frmMantPlanesCREAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstCobertura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lstCoberturaPlan;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.CheckBox chcFamiliar;
        private System.Windows.Forms.Label lblCoberturas;
        private System.Windows.Forms.Label lblCoberturasPlan;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.MaskedTextBox mskCosto;
        private System.Windows.Forms.MaskedTextBox mskID;
    }
}