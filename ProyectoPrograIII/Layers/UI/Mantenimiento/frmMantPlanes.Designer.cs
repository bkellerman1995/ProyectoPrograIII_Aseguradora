
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantPlanes
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
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarPlan = new System.Windows.Forms.Button();
            this.btnActualizarPlan = new System.Windows.Forms.Button();
            this.btnCrearPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombrePlan,
            this.Familiar,
            this.CostoPlan});
            this.dgvPlanes.Location = new System.Drawing.Point(20, 335);
            this.dgvPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.RowHeadersVisible = false;
            this.dgvPlanes.RowHeadersWidth = 102;
            this.dgvPlanes.RowTemplate.Height = 40;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(2066, 1371);
            this.dgvPlanes.TabIndex = 10;
            this.dgvPlanes.TabStop = false;
            this.dgvPlanes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellContentDoubleClick);
            this.dgvPlanes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPlanes_CellFormatting);
            this.dgvPlanes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPlanes_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NombrePlan
            // 
            this.NombrePlan.DataPropertyName = "NombrePlan";
            this.NombrePlan.HeaderText = "Nombre de Plan";
            this.NombrePlan.MinimumWidth = 12;
            this.NombrePlan.Name = "NombrePlan";
            this.NombrePlan.ReadOnly = true;
            // 
            // Familiar
            // 
            this.Familiar.DataPropertyName = "Familiar";
            this.Familiar.HeaderText = "Familiar";
            this.Familiar.MinimumWidth = 12;
            this.Familiar.Name = "Familiar";
            this.Familiar.ReadOnly = true;
            // 
            // CostoPlan
            // 
            this.CostoPlan.DataPropertyName = "CostoPlan";
            this.CostoPlan.HeaderText = "Costo de Plan";
            this.CostoPlan.MinimumWidth = 12;
            this.CostoPlan.Name = "CostoPlan";
            this.CostoPlan.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(1799, 1749);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(312, 132);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarPlan
            // 
            this.btnEliminarPlan.BackColor = System.Drawing.Color.White;
            this.btnEliminarPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarPlan.Image = global::ProyectoPrograIII.Properties.Resources.delete3;
            this.btnEliminarPlan.Location = new System.Drawing.Point(1361, 70);
            this.btnEliminarPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPlan.Name = "btnEliminarPlan";
            this.btnEliminarPlan.Size = new System.Drawing.Size(435, 183);
            this.btnEliminarPlan.TabIndex = 8;
            this.btnEliminarPlan.Text = "Eliminar Plan";
            this.btnEliminarPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPlan.UseVisualStyleBackColor = false;
            this.btnEliminarPlan.Click += new System.EventHandler(this.btnEliminarPlan_Click);
            // 
            // btnActualizarPlan
            // 
            this.btnActualizarPlan.BackColor = System.Drawing.Color.White;
            this.btnActualizarPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnActualizarPlan.Image = global::ProyectoPrograIII.Properties.Resources.pencil4;
            this.btnActualizarPlan.Location = new System.Drawing.Point(755, 70);
            this.btnActualizarPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPlan.Name = "btnActualizarPlan";
            this.btnActualizarPlan.Size = new System.Drawing.Size(505, 183);
            this.btnActualizarPlan.TabIndex = 7;
            this.btnActualizarPlan.Text = "Actualizar Plan";
            this.btnActualizarPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarPlan.UseVisualStyleBackColor = false;
            this.btnActualizarPlan.Click += new System.EventHandler(this.btnActualizarPlan_Click);
            // 
            // btnCrearPlan
            // 
            this.btnCrearPlan.BackColor = System.Drawing.Color.White;
            this.btnCrearPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearPlan.Image = global::ProyectoPrograIII.Properties.Resources.create;
            this.btnCrearPlan.Location = new System.Drawing.Point(94, 70);
            this.btnCrearPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPlan.Name = "btnCrearPlan";
            this.btnCrearPlan.Size = new System.Drawing.Size(568, 183);
            this.btnCrearPlan.TabIndex = 6;
            this.btnCrearPlan.Text = "Crear Plan";
            this.btnCrearPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPlan.UseVisualStyleBackColor = false;
            this.btnCrearPlan.Click += new System.EventHandler(this.btnCrearPlan_Click);
            // 
            // frmMantPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2181, 1879);
            this.Controls.Add(this.dgvPlanes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarPlan);
            this.Controls.Add(this.btnActualizarPlan);
            this.Controls.Add(this.btnCrearPlan);
            this.Name = "frmMantPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Planes";
            this.Load += new System.EventHandler(this.frmMantPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarPlan;
        private System.Windows.Forms.Button btnActualizarPlan;
        private System.Windows.Forms.Button btnCrearPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPlan;
    }
}