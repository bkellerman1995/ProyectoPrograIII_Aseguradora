
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantCoberturasUPDATE
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
            this.lblNumEventos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMontoMaximo = new System.Windows.Forms.Label();
            this.lblPrima = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.mskNumEventos = new System.Windows.Forms.MaskedTextBox();
            this.mskMontoMaximo = new System.Windows.Forms.MaskedTextBox();
            this.mskPrima = new System.Windows.Forms.MaskedTextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNumEventos
            // 
            this.lblNumEventos.AutoSize = true;
            this.lblNumEventos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEventos.Location = new System.Drawing.Point(12, 650);
            this.lblNumEventos.Name = "lblNumEventos";
            this.lblNumEventos.Size = new System.Drawing.Size(552, 54);
            this.lblNumEventos.TabIndex = 79;
            this.lblNumEventos.Text = "Numero de eventos por año";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(734, 1064);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(336, 164);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Location = new System.Drawing.Point(12, 1045);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(420, 183);
            this.btnActualizar.TabIndex = 64;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(281, 201);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(789, 53);
            this.txtNombre.TabIndex = 61;
            // 
            // lblMontoMaximo
            // 
            this.lblMontoMaximo.AutoSize = true;
            this.lblMontoMaximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaximo.Location = new System.Drawing.Point(12, 478);
            this.lblMontoMaximo.Name = "lblMontoMaximo";
            this.lblMontoMaximo.Size = new System.Drawing.Size(945, 135);
            this.lblMontoMaximo.TabIndex = 59;
            this.lblMontoMaximo.Text = "Monto Maximo ($)";
            // 
            // lblPrima
            // 
            this.lblPrima.AutoSize = true;
            this.lblPrima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrima.Location = new System.Drawing.Point(12, 327);
            this.lblPrima.Name = "lblPrima";
            this.lblPrima.Size = new System.Drawing.Size(495, 135);
            this.lblPrima.TabIndex = 58;
            this.lblPrima.Text = "Prima ($)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 189);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 54);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 54);
            this.lblID.TabIndex = 83;
            this.lblID.Text = "ID";
            // 
            // mskNumEventos
            // 
            this.mskNumEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumEventos.Location = new System.Drawing.Point(682, 650);
            this.mskNumEventos.Mask = "9";
            this.mskNumEventos.Name = "mskNumEventos";
            this.mskNumEventos.Size = new System.Drawing.Size(388, 53);
            this.mskNumEventos.TabIndex = 102;
            // 
            // mskMontoMaximo
            // 
            this.mskMontoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMontoMaximo.Location = new System.Drawing.Point(682, 478);
            this.mskMontoMaximo.Mask = "9999";
            this.mskMontoMaximo.Name = "mskMontoMaximo";
            this.mskMontoMaximo.Size = new System.Drawing.Size(388, 53);
            this.mskMontoMaximo.TabIndex = 101;
            // 
            // mskPrima
            // 
            this.mskPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrima.Location = new System.Drawing.Point(682, 330);
            this.mskPrima.Mask = "999";
            this.mskPrima.Name = "mskPrima";
            this.mskPrima.Size = new System.Drawing.Size(388, 53);
            this.mskPrima.TabIndex = 100;
            // 
            // mskID
            // 
            this.mskID.Enabled = false;
            this.mskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskID.Location = new System.Drawing.Point(755, 41);
            this.mskID.Mask = "AAA";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(315, 53);
            this.mskID.TabIndex = 103;
            // 
            // frmMantCoberturasUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 1252);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.mskNumEventos);
            this.Controls.Add(this.mskMontoMaximo);
            this.Controls.Add(this.mskPrima);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNumEventos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMontoMaximo);
            this.Controls.Add(this.lblPrima);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMantCoberturasUPDATE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Cobertura";
            this.Load += new System.EventHandler(this.frmMantCoberturasUPDATE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumEventos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMontoMaximo;
        private System.Windows.Forms.Label lblPrima;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MaskedTextBox mskNumEventos;
        private System.Windows.Forms.MaskedTextBox mskMontoMaximo;
        private System.Windows.Forms.MaskedTextBox mskPrima;
        private System.Windows.Forms.MaskedTextBox mskID;
    }
}