
namespace ProyectoPrograIII.Layers.UI.Mantenimiento
{
    partial class frmMantCoberturas
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
            this.dgvCoberturas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEventosAnno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarCobertura = new System.Windows.Forms.Button();
            this.btnActualizarCobertura = new System.Windows.Forms.Button();
            this.btnCrearCobertura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoberturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(2059, 1814);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(312, 120);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCoberturas
            // 
            this.dgvCoberturas.AllowUserToDeleteRows = false;
            this.dgvCoberturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoberturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoberturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Prima,
            this.MontoMaximo,
            this.NumEventosAnno});
            this.dgvCoberturas.Location = new System.Drawing.Point(45, 300);
            this.dgvCoberturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCoberturas.Name = "dgvCoberturas";
            this.dgvCoberturas.RowHeadersVisible = false;
            this.dgvCoberturas.RowHeadersWidth = 102;
            this.dgvCoberturas.RowTemplate.Height = 40;
            this.dgvCoberturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoberturas.Size = new System.Drawing.Size(2298, 1497);
            this.dgvCoberturas.TabIndex = 5;
            this.dgvCoberturas.TabStop = false;
            this.dgvCoberturas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoberturas_CellContentDoubleClick);
            this.dgvCoberturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCoberturas_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDCobertura";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 12;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Prima
            // 
            this.Prima.DataPropertyName = "Prima";
            this.Prima.HeaderText = "Prima";
            this.Prima.MinimumWidth = 12;
            this.Prima.Name = "Prima";
            this.Prima.ReadOnly = true;
            // 
            // MontoMaximo
            // 
            this.MontoMaximo.DataPropertyName = "MontoMaximo";
            this.MontoMaximo.HeaderText = "Monto Maximo";
            this.MontoMaximo.MinimumWidth = 12;
            this.MontoMaximo.Name = "MontoMaximo";
            this.MontoMaximo.ReadOnly = true;
            // 
            // NumEventosAnno
            // 
            this.NumEventosAnno.DataPropertyName = "NumEventosAnno";
            this.NumEventosAnno.HeaderText = "Numero de Eventos por Año";
            this.NumEventosAnno.MinimumWidth = 12;
            this.NumEventosAnno.Name = "NumEventosAnno";
            this.NumEventosAnno.ReadOnly = true;
            // 
            // btnEliminarCobertura
            // 
            this.btnEliminarCobertura.BackColor = System.Drawing.Color.White;
            this.btnEliminarCobertura.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCobertura.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarCobertura.Image = global::ProyectoPrograIII.Properties.Resources.delete3;
            this.btnEliminarCobertura.Location = new System.Drawing.Point(1396, 30);
            this.btnEliminarCobertura.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCobertura.Name = "btnEliminarCobertura";
            this.btnEliminarCobertura.Size = new System.Drawing.Size(613, 195);
            this.btnEliminarCobertura.TabIndex = 3;
            this.btnEliminarCobertura.Text = "Eliminar Cobertura";
            this.btnEliminarCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCobertura.UseVisualStyleBackColor = false;
            this.btnEliminarCobertura.Click += new System.EventHandler(this.btnEliminarCobertura_Click);
            // 
            // btnActualizarCobertura
            // 
            this.btnActualizarCobertura.BackColor = System.Drawing.Color.White;
            this.btnActualizarCobertura.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCobertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnActualizarCobertura.Image = global::ProyectoPrograIII.Properties.Resources.pencil4;
            this.btnActualizarCobertura.Location = new System.Drawing.Point(695, 30);
            this.btnActualizarCobertura.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCobertura.Name = "btnActualizarCobertura";
            this.btnActualizarCobertura.Size = new System.Drawing.Size(658, 195);
            this.btnActualizarCobertura.TabIndex = 2;
            this.btnActualizarCobertura.Text = "Actualizar Cobertura";
            this.btnActualizarCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarCobertura.UseVisualStyleBackColor = false;
            this.btnActualizarCobertura.Click += new System.EventHandler(this.btnActualizarCobertura_Click);
            // 
            // btnCrearCobertura
            // 
            this.btnCrearCobertura.BackColor = System.Drawing.Color.White;
            this.btnCrearCobertura.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCobertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearCobertura.Image = global::ProyectoPrograIII.Properties.Resources.create;
            this.btnCrearCobertura.Location = new System.Drawing.Point(72, 30);
            this.btnCrearCobertura.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCobertura.Name = "btnCrearCobertura";
            this.btnCrearCobertura.Size = new System.Drawing.Size(568, 195);
            this.btnCrearCobertura.TabIndex = 0;
            this.btnCrearCobertura.Text = "Crear Cobertura";
            this.btnCrearCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCobertura.UseVisualStyleBackColor = false;
            this.btnCrearCobertura.Click += new System.EventHandler(this.btnCrearCobertura_Click);
            // 
            // frmMantCoberturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2382, 1945);
            this.Controls.Add(this.dgvCoberturas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarCobertura);
            this.Controls.Add(this.btnActualizarCobertura);
            this.Controls.Add(this.btnCrearCobertura);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMantCoberturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Coberturas";
            this.Load += new System.EventHandler(this.frmMantCoberturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoberturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCobertura;
        private System.Windows.Forms.Button btnActualizarCobertura;
        private System.Windows.Forms.Button btnEliminarCobertura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCoberturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEventosAnno;
    }
}