
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantPoliza
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
            this.dgvPoliza = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipoPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarPoliza = new System.Windows.Forms.Button();
            this.btnActualizarPoliza = new System.Windows.Forms.Button();
            this.btnCrearPoliza = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoliza
            // 
            this.dgvPoliza.AllowUserToDeleteRows = false;
            this.dgvPoliza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.IDTipoPlan,
            this.Cliente});
            this.dgvPoliza.Location = new System.Drawing.Point(45, 300);
            this.dgvPoliza.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPoliza.Name = "dgvPoliza";
            this.dgvPoliza.RowHeadersVisible = false;
            this.dgvPoliza.RowHeadersWidth = 102;
            this.dgvPoliza.RowTemplate.Height = 40;
            this.dgvPoliza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoliza.Size = new System.Drawing.Size(2298, 1175);
            this.dgvPoliza.TabIndex = 5;
            this.dgvPoliza.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoliza_CellContentDoubleClick);
            this.dgvPoliza.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPoliza_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 12;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IDTipoPlan
            // 
            this.IDTipoPlan.DataPropertyName = "Plan";
            this.IDTipoPlan.HeaderText = "Plan";
            this.IDTipoPlan.MinimumWidth = 12;
            this.IDTipoPlan.Name = "IDTipoPlan";
            this.IDTipoPlan.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 12;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // btnEliminarPoliza
            // 
            this.btnEliminarPoliza.BackColor = System.Drawing.Color.White;
            this.btnEliminarPoliza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPoliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarPoliza.Image = global::ProyectoPrograIII.Properties.Resources.delete3;
            this.btnEliminarPoliza.Location = new System.Drawing.Point(1237, 67);
            this.btnEliminarPoliza.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPoliza.Name = "btnEliminarPoliza";
            this.btnEliminarPoliza.Size = new System.Drawing.Size(435, 183);
            this.btnEliminarPoliza.TabIndex = 12;
            this.btnEliminarPoliza.Text = "Eliminar Póliza ";
            this.btnEliminarPoliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPoliza.UseVisualStyleBackColor = false;
            this.btnEliminarPoliza.Click += new System.EventHandler(this.btnEliminarPoliza_Click);
            // 
            // btnActualizarPoliza
            // 
            this.btnActualizarPoliza.BackColor = System.Drawing.Color.White;
            this.btnActualizarPoliza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPoliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnActualizarPoliza.Image = global::ProyectoPrograIII.Properties.Resources.pencil4;
            this.btnActualizarPoliza.Location = new System.Drawing.Point(694, 67);
            this.btnActualizarPoliza.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPoliza.Name = "btnActualizarPoliza";
            this.btnActualizarPoliza.Size = new System.Drawing.Size(505, 183);
            this.btnActualizarPoliza.TabIndex = 11;
            this.btnActualizarPoliza.Text = "Actualizar Póliza ";
            this.btnActualizarPoliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarPoliza.UseVisualStyleBackColor = false;
            this.btnActualizarPoliza.Click += new System.EventHandler(this.btnActualizarPoliza_Click);
            // 
            // btnCrearPoliza
            // 
            this.btnCrearPoliza.BackColor = System.Drawing.Color.White;
            this.btnCrearPoliza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPoliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearPoliza.Image = global::ProyectoPrograIII.Properties.Resources.create;
            this.btnCrearPoliza.Location = new System.Drawing.Point(71, 67);
            this.btnCrearPoliza.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPoliza.Name = "btnCrearPoliza";
            this.btnCrearPoliza.Size = new System.Drawing.Size(568, 183);
            this.btnCrearPoliza.TabIndex = 10;
            this.btnCrearPoliza.Text = "Crear Póliza ";
            this.btnCrearPoliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPoliza.UseVisualStyleBackColor = false;
            this.btnCrearPoliza.Click += new System.EventHandler(this.btnCrearPoliza_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(1950, 1504);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(408, 150);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMantPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2382, 1692);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarPoliza);
            this.Controls.Add(this.btnActualizarPoliza);
            this.Controls.Add(this.btnCrearPoliza);
            this.Controls.Add(this.dgvPoliza);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMantPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Polizas";
            this.Load += new System.EventHandler(this.frmMantCoberturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPoliza;
        private System.Windows.Forms.Button btnEliminarPoliza;
        private System.Windows.Forms.Button btnActualizarPoliza;
        private System.Windows.Forms.Button btnCrearPoliza;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipoPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
    }
}