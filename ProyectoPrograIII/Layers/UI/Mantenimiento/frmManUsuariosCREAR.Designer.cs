
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmManUsuariosCREAR
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblIDRol = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.rdHabilitado = new System.Windows.Forms.RadioButton();
            this.rdDeshabilitado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 59);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 32);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 154);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 32);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 231);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(162, 32);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Contraseña";
            // 
            // lblIDRol
            // 
            this.lblIDRol.AutoSize = true;
            this.lblIDRol.Location = new System.Drawing.Point(22, 399);
            this.lblIDRol.Name = "lblIDRol";
            this.lblIDRol.Size = new System.Drawing.Size(58, 32);
            this.lblIDRol.TabIndex = 3;
            this.lblIDRol.Text = "Rol";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(330, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(355, 38);
            this.txtID.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(330, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(355, 38);
            this.txtNombre.TabIndex = 6;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(12, 310);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(293, 32);
            this.lblConfirmPwd.TabIndex = 7;
            this.lblConfirmPwd.Text = "Confirmar Contraseña";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(330, 228);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(355, 38);
            this.txtPwd.TabIndex = 8;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(330, 319);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(355, 38);
            this.txtConfirmPwd.TabIndex = 9;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(330, 392);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(355, 39);
            this.cmbRol.TabIndex = 10;
            // 
            // rdHabilitado
            // 
            this.rdHabilitado.AutoSize = true;
            this.rdHabilitado.Location = new System.Drawing.Point(54, 559);
            this.rdHabilitado.Name = "rdHabilitado";
            this.rdHabilitado.Size = new System.Drawing.Size(181, 36);
            this.rdHabilitado.TabIndex = 11;
            this.rdHabilitado.TabStop = true;
            this.rdHabilitado.Text = "Habilitado";
            this.rdHabilitado.UseVisualStyleBackColor = true;
            // 
            // rdDeshabilitado
            // 
            this.rdDeshabilitado.AutoSize = true;
            this.rdDeshabilitado.Location = new System.Drawing.Point(410, 559);
            this.rdDeshabilitado.Name = "rdDeshabilitado";
            this.rdDeshabilitado.Size = new System.Drawing.Size(227, 36);
            this.rdDeshabilitado.TabIndex = 12;
            this.rdDeshabilitado.TabStop = true;
            this.rdDeshabilitado.Text = "Deshabilitado";
            this.rdDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // frmManUsuariosCREAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 849);
            this.Controls.Add(this.rdDeshabilitado);
            this.Controls.Add(this.rdHabilitado);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDRol);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmManUsuariosCREAR";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.frmManUsuariosCREAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblIDRol;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.RadioButton rdHabilitado;
        private System.Windows.Forms.RadioButton rdDeshabilitado;
    }
}