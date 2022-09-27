namespace pryMigotti___SP1H1
{
    partial class frmConsultaLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaLocalidad));
            this.btnLimpiarCClientes = new System.Windows.Forms.Button();
            this.dgvConsultaLocalidad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalirCClientes = new System.Windows.Forms.Button();
            this.btnListarCClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCClientes
            // 
            this.btnLimpiarCClientes.Location = new System.Drawing.Point(100, 168);
            this.btnLimpiarCClientes.Name = "btnLimpiarCClientes";
            this.btnLimpiarCClientes.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCClientes.TabIndex = 11;
            this.btnLimpiarCClientes.Text = "Limpiar";
            this.btnLimpiarCClientes.UseVisualStyleBackColor = true;
            this.btnLimpiarCClientes.Click += new System.EventHandler(this.btnLimpiarCClientes_Click);
            // 
            // dgvConsultaLocalidad
            // 
            this.dgvConsultaLocalidad.AllowUserToAddRows = false;
            this.dgvConsultaLocalidad.AllowUserToDeleteRows = false;
            this.dgvConsultaLocalidad.AllowUserToResizeColumns = false;
            this.dgvConsultaLocalidad.AllowUserToResizeRows = false;
            this.dgvConsultaLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLocalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaLocalidad.Location = new System.Drawing.Point(18, 9);
            this.dgvConsultaLocalidad.Name = "dgvConsultaLocalidad";
            this.dgvConsultaLocalidad.ReadOnly = true;
            this.dgvConsultaLocalidad.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaLocalidad.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificación";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnSalirCClientes
            // 
            this.btnSalirCClientes.Location = new System.Drawing.Point(18, 168);
            this.btnSalirCClientes.Name = "btnSalirCClientes";
            this.btnSalirCClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCClientes.TabIndex = 9;
            this.btnSalirCClientes.Text = "Salir";
            this.btnSalirCClientes.UseVisualStyleBackColor = true;
            this.btnSalirCClientes.Click += new System.EventHandler(this.btnSalirCClientes_Click);
            // 
            // btnListarCClientes
            // 
            this.btnListarCClientes.Location = new System.Drawing.Point(182, 168);
            this.btnListarCClientes.Name = "btnListarCClientes";
            this.btnListarCClientes.Size = new System.Drawing.Size(75, 23);
            this.btnListarCClientes.TabIndex = 8;
            this.btnListarCClientes.Text = "Listar";
            this.btnListarCClientes.UseVisualStyleBackColor = true;
            this.btnListarCClientes.Click += new System.EventHandler(this.btnListarCClientes_Click);
            // 
            // frmConsultaLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 200);
            this.Controls.Add(this.btnLimpiarCClientes);
            this.Controls.Add(this.dgvConsultaLocalidad);
            this.Controls.Add(this.btnSalirCClientes);
            this.Controls.Add(this.btnListarCClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Localidad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarCClientes;
        private System.Windows.Forms.DataGridView dgvConsultaLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnSalirCClientes;
        private System.Windows.Forms.Button btnListarCClientes;
    }
}