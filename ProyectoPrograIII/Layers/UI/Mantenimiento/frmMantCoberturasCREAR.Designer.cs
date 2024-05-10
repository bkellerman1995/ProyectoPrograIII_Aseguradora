
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantCoberturasCREAR
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumEventos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMontoMaximo = new System.Windows.Forms.Label();
            this.lblPrima = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mskPrima = new System.Windows.Forms.MaskedTextBox();
            this.mskMontoMaximo = new System.Windows.Forms.MaskedTextBox();
            this.mskNumEventos = new System.Windows.Forms.MaskedTextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(78, -86);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 46);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 54);
            this.label1.TabIndex = 95;
            this.label1.Text = "ID";
            // 
            // lblNumEventos
            // 
            this.lblNumEventos.AutoSize = true;
            this.lblNumEventos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEventos.Location = new System.Drawing.Point(27, 676);
            this.lblNumEventos.Name = "lblNumEventos";
            this.lblNumEventos.Size = new System.Drawing.Size(552, 54);
            this.lblNumEventos.TabIndex = 93;
            this.lblNumEventos.Text = "Numero de eventos por año";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(1099, 1018);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(235, 83);
            this.btnCancelar.TabIndex = 92;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrear.Location = new System.Drawing.Point(12, 954);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(362, 147);
            this.btnCrear.TabIndex = 91;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(638, 198);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(696, 53);
            this.txtNombre.TabIndex = 88;
            // 
            // lblMontoMaximo
            // 
            this.lblMontoMaximo.AutoSize = true;
            this.lblMontoMaximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaximo.Location = new System.Drawing.Point(27, 502);
            this.lblMontoMaximo.Name = "lblMontoMaximo";
            this.lblMontoMaximo.Size = new System.Drawing.Size(945, 135);
            this.lblMontoMaximo.TabIndex = 87;
            this.lblMontoMaximo.Text = "Monto Maximo ($)";
            // 
            // lblPrima
            // 
            this.lblPrima.AutoSize = true;
            this.lblPrima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrima.Location = new System.Drawing.Point(27, 337);
            this.lblPrima.Name = "lblPrima";
            this.lblPrima.Size = new System.Drawing.Size(495, 135);
            this.lblPrima.TabIndex = 86;
            this.lblPrima.Text = "Prima ($)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 195);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 54);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "Nombre";
            // 
            // mskPrima
            // 
            this.mskPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrima.Location = new System.Drawing.Point(859, 340);
            this.mskPrima.Mask = "999";
            this.mskPrima.Name = "mskPrima";
            this.mskPrima.Size = new System.Drawing.Size(475, 53);
            this.mskPrima.TabIndex = 97;
            // 
            // mskMontoMaximo
            // 
            this.mskMontoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMontoMaximo.Location = new System.Drawing.Point(859, 502);
            this.mskMontoMaximo.Mask = "9999";
            this.mskMontoMaximo.Name = "mskMontoMaximo";
            this.mskMontoMaximo.Size = new System.Drawing.Size(475, 53);
            this.mskMontoMaximo.TabIndex = 98;
            // 
            // mskNumEventos
            // 
            this.mskNumEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumEventos.Location = new System.Drawing.Point(859, 676);
            this.mskNumEventos.Mask = "9";
            this.mskNumEventos.Name = "mskNumEventos";
            this.mskNumEventos.Size = new System.Drawing.Size(475, 53);
            this.mskNumEventos.TabIndex = 99;
            // 
            // mskID
            // 
            this.mskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskID.Location = new System.Drawing.Point(932, 72);
            this.mskID.Mask = "AAA";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(402, 53);
            this.mskID.TabIndex = 100;
            // 
            // frmMantCoberturasCREAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1375, 1166);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.mskNumEventos);
            this.Controls.Add(this.mskMontoMaximo);
            this.Controls.Add(this.mskPrima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumEventos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMontoMaximo);
            this.Controls.Add(this.lblPrima);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMantCoberturasCREAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cobertura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumEventos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMontoMaximo;
        private System.Windows.Forms.Label lblPrima;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mskPrima;
        private System.Windows.Forms.MaskedTextBox mskMontoMaximo;
        private System.Windows.Forms.MaskedTextBox mskNumEventos;
        private System.Windows.Forms.MaskedTextBox mskID;
    }
}