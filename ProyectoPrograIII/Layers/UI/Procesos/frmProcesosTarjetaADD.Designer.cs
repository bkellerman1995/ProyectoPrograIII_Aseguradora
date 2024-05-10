
namespace ProyectoPrograIII.Layers.UI.Procesos
{
    partial class frmProcesosTarjetaADD
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
            this.lblNoTarjeta = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.lblfechaExpiracion = new System.Windows.Forms.Label();
            this.mskNoTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.mskCVC = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.picVisa = new System.Windows.Forms.PictureBox();
            this.picMastercard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMastercard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoTarjeta
            // 
            this.lblNoTarjeta.AutoSize = true;
            this.lblNoTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTarjeta.Location = new System.Drawing.Point(31, 200);
            this.lblNoTarjeta.Name = "lblNoTarjeta";
            this.lblNoTarjeta.Size = new System.Drawing.Size(230, 54);
            this.lblNoTarjeta.TabIndex = 0;
            this.lblNoTarjeta.Text = "No. Tarjeta";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 290);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(242, 54);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.Location = new System.Drawing.Point(31, 372);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(99, 54);
            this.lblCVC.TabIndex = 2;
            this.lblCVC.Text = "CVC";
            // 
            // lblfechaExpiracion
            // 
            this.lblfechaExpiracion.AutoSize = true;
            this.lblfechaExpiracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaExpiracion.Location = new System.Drawing.Point(31, 465);
            this.lblfechaExpiracion.Name = "lblfechaExpiracion";
            this.lblfechaExpiracion.Size = new System.Drawing.Size(396, 54);
            this.lblfechaExpiracion.TabIndex = 3;
            this.lblfechaExpiracion.Text = "Fecha de expiración";
            // 
            // mskNoTarjeta
            // 
            this.mskNoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNoTarjeta.Location = new System.Drawing.Point(660, 209);
            this.mskNoTarjeta.Mask = "9999999999999999";
            this.mskNoTarjeta.Name = "mskNoTarjeta";
            this.mskNoTarjeta.Size = new System.Drawing.Size(378, 45);
            this.mskNoTarjeta.TabIndex = 8;
            // 
            // mskCVC
            // 
            this.mskCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCVC.Location = new System.Drawing.Point(660, 392);
            this.mskCVC.Mask = "999";
            this.mskCVC.Name = "mskCVC";
            this.mskCVC.Size = new System.Drawing.Size(378, 45);
            this.mskCVC.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 474);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(581, 45);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 21, 0, 0, 0, 0);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(21, 677);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(321, 147);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(755, 677);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(283, 156);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(663, 293);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(375, 45);
            this.txtDescripcion.TabIndex = 14;
            // 
            // picVisa
            // 
            this.picVisa.Image = global::ProyectoPrograIII.Properties.Resources.Visa;
            this.picVisa.Location = new System.Drawing.Point(429, 35);
            this.picVisa.Name = "picVisa";
            this.picVisa.Size = new System.Drawing.Size(360, 168);
            this.picVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVisa.TabIndex = 16;
            this.picVisa.TabStop = false;
            // 
            // picMastercard
            // 
            this.picMastercard.Image = global::ProyectoPrograIII.Properties.Resources.Mastercard;
            this.picMastercard.Location = new System.Drawing.Point(40, 27);
            this.picMastercard.Name = "picMastercard";
            this.picMastercard.Size = new System.Drawing.Size(302, 170);
            this.picMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMastercard.TabIndex = 15;
            this.picMastercard.TabStop = false;
            // 
            // frmProcesosTarjetaADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1073, 874);
            this.Controls.Add(this.picVisa);
            this.Controls.Add(this.picMastercard);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mskCVC);
            this.Controls.Add(this.mskNoTarjeta);
            this.Controls.Add(this.lblfechaExpiracion);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNoTarjeta);
            this.Name = "frmProcesosTarjetaADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.picVisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMastercard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoTarjeta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Label lblfechaExpiracion;
        private System.Windows.Forms.MaskedTextBox mskNoTarjeta;
        private System.Windows.Forms.MaskedTextBox mskCVC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox picMastercard;
        private System.Windows.Forms.PictureBox picVisa;
    }
}