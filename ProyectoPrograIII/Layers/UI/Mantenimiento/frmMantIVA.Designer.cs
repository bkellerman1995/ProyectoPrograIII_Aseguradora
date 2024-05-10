
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantIVA
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarIVA = new System.Windows.Forms.Button();
            this.btnActualizarIVA = new System.Windows.Forms.Button();
            this.btnCrearIVA = new System.Windows.Forms.Button();
            this.dgvImpuesto = new System.Windows.Forms.DataGridView();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(1781, 1531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(332, 131);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarIVA
            // 
            this.btnEliminarIVA.BackColor = System.Drawing.Color.White;
            this.btnEliminarIVA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarIVA.Image = global::ProyectoPrograIII.Properties.Resources.delete3;
            this.btnEliminarIVA.Location = new System.Drawing.Point(1290, 31);
            this.btnEliminarIVA.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarIVA.Name = "btnEliminarIVA";
            this.btnEliminarIVA.Size = new System.Drawing.Size(465, 209);
            this.btnEliminarIVA.TabIndex = 11;
            this.btnEliminarIVA.Text = "EliminarIVA";
            this.btnEliminarIVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarIVA.UseVisualStyleBackColor = false;
            this.btnEliminarIVA.Click += new System.EventHandler(this.btnEliminarIVA_Click);
            // 
            // btnActualizarIVA
            // 
            this.btnActualizarIVA.BackColor = System.Drawing.Color.White;
            this.btnActualizarIVA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnActualizarIVA.Image = global::ProyectoPrograIII.Properties.Resources.pencil4;
            this.btnActualizarIVA.Location = new System.Drawing.Point(713, 31);
            this.btnActualizarIVA.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarIVA.Name = "btnActualizarIVA";
            this.btnActualizarIVA.Size = new System.Drawing.Size(535, 209);
            this.btnActualizarIVA.TabIndex = 10;
            this.btnActualizarIVA.Text = "Actualizar IVA";
            this.btnActualizarIVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarIVA.UseVisualStyleBackColor = false;
            this.btnActualizarIVA.Click += new System.EventHandler(this.btnActualizarIVA_Click);
            // 
            // btnCrearIVA
            // 
            this.btnCrearIVA.BackColor = System.Drawing.Color.White;
            this.btnCrearIVA.Enabled = false;
            this.btnCrearIVA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearIVA.Image = global::ProyectoPrograIII.Properties.Resources.create;
            this.btnCrearIVA.Location = new System.Drawing.Point(76, 31);
            this.btnCrearIVA.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearIVA.Name = "btnCrearIVA";
            this.btnCrearIVA.Size = new System.Drawing.Size(598, 209);
            this.btnCrearIVA.TabIndex = 9;
            this.btnCrearIVA.Text = "Crear IVA";
            this.btnCrearIVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearIVA.UseVisualStyleBackColor = false;
            this.btnCrearIVA.Click += new System.EventHandler(this.btnCrearIVA_Click);
            // 
            // dgvImpuesto
            // 
            this.dgvImpuesto.AllowUserToDeleteRows = false;
            this.dgvImpuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImpuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Porcentaje});
            this.dgvImpuesto.Location = new System.Drawing.Point(24, 300);
            this.dgvImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvImpuesto.Name = "dgvImpuesto";
            this.dgvImpuesto.RowHeadersVisible = false;
            this.dgvImpuesto.RowHeadersWidth = 102;
            this.dgvImpuesto.RowTemplate.Height = 40;
            this.dgvImpuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpuesto.Size = new System.Drawing.Size(2077, 1085);
            this.dgvImpuesto.TabIndex = 12;
            this.dgvImpuesto.TabStop = false;
            this.dgvImpuesto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpuesto_CellContentDoubleClick);
            this.dgvImpuesto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvImpuesto_CellFormatting);
            this.dgvImpuesto.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvImpuesto_DataBindingComplete);
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.MinimumWidth = 12;
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // frmMantIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2158, 1755);
            this.Controls.Add(this.dgvImpuesto);
            this.Controls.Add(this.btnEliminarIVA);
            this.Controls.Add(this.btnActualizarIVA);
            this.Controls.Add(this.btnCrearIVA);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmMantIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento IVA";
            this.Load += new System.EventHandler(this.frmMantIVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarIVA;
        private System.Windows.Forms.Button btnActualizarIVA;
        private System.Windows.Forms.Button btnCrearIVA;
        private System.Windows.Forms.DataGridView dgvImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}