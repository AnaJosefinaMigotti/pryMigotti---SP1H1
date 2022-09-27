namespace pryMigotti___SP1H1
{
    partial class frmConsultaProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduccion));
            this.btnLimpiarCVentas = new System.Windows.Forms.Button();
            this.dgvConsultaProduccion = new System.Windows.Forms.DataGridView();
            this.btnSalirCVentas = new System.Windows.Forms.Button();
            this.btnListarCVentas = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCVentas
            // 
            this.btnLimpiarCVentas.Location = new System.Drawing.Point(93, 171);
            this.btnLimpiarCVentas.Name = "btnLimpiarCVentas";
            this.btnLimpiarCVentas.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCVentas.TabIndex = 17;
            this.btnLimpiarCVentas.Text = "Limpiar";
            this.btnLimpiarCVentas.UseVisualStyleBackColor = true;
            this.btnLimpiarCVentas.Click += new System.EventHandler(this.btnLimpiarCVentas_Click);
            // 
            // dgvConsultaProduccion
            // 
            this.dgvConsultaProduccion.AllowUserToAddRows = false;
            this.dgvConsultaProduccion.AllowUserToDeleteRows = false;
            this.dgvConsultaProduccion.AllowUserToResizeColumns = false;
            this.dgvConsultaProduccion.AllowUserToResizeRows = false;
            this.dgvConsultaProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvConsultaProduccion.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaProduccion.Name = "dgvConsultaProduccion";
            this.dgvConsultaProduccion.ReadOnly = true;
            this.dgvConsultaProduccion.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaProduccion.TabIndex = 16;
            // 
            // btnSalirCVentas
            // 
            this.btnSalirCVentas.Location = new System.Drawing.Point(12, 171);
            this.btnSalirCVentas.Name = "btnSalirCVentas";
            this.btnSalirCVentas.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCVentas.TabIndex = 15;
            this.btnSalirCVentas.Text = "Salir";
            this.btnSalirCVentas.UseVisualStyleBackColor = true;
            this.btnSalirCVentas.Click += new System.EventHandler(this.btnSalirCVentas_Click);
            // 
            // btnListarCVentas
            // 
            this.btnListarCVentas.Location = new System.Drawing.Point(174, 171);
            this.btnListarCVentas.Name = "btnListarCVentas";
            this.btnListarCVentas.Size = new System.Drawing.Size(75, 23);
            this.btnListarCVentas.TabIndex = 14;
            this.btnListarCVentas.Text = "Listar";
            this.btnListarCVentas.UseVisualStyleBackColor = true;
            this.btnListarCVentas.Click += new System.EventHandler(this.btnListarCVentas_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cultivo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Producción";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmConsultaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 201);
            this.Controls.Add(this.btnLimpiarCVentas);
            this.Controls.Add(this.dgvConsultaProduccion);
            this.Controls.Add(this.btnSalirCVentas);
            this.Controls.Add(this.btnListarCVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultaProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarCVentas;
        private System.Windows.Forms.DataGridView dgvConsultaProduccion;
        private System.Windows.Forms.Button btnSalirCVentas;
        private System.Windows.Forms.Button btnListarCVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}