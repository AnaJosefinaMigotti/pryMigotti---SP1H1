namespace pryMigotti___SP1H1
{
    partial class frmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lstNombreCultivo = new System.Windows.Forms.ComboBox();
            this.lstNombreLocalidad = new System.Windows.Forms.ComboBox();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.Location = new System.Drawing.Point(125, 86);
            this.mtbCantidad.Mask = "99999";
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(122, 20);
            this.mtbCantidad.TabIndex = 14;
            this.mtbCantidad.ValidatingType = typeof(int);
            // 
            // lstNombreCultivo
            // 
            this.lstNombreCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreCultivo.FormattingEnabled = true;
            this.lstNombreCultivo.Location = new System.Drawing.Point(125, 59);
            this.lstNombreCultivo.Name = "lstNombreCultivo";
            this.lstNombreCultivo.Size = new System.Drawing.Size(122, 21);
            this.lstNombreCultivo.TabIndex = 12;
            // 
            // lstNombreLocalidad
            // 
            this.lstNombreLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreLocalidad.FormattingEnabled = true;
            this.lstNombreLocalidad.Location = new System.Drawing.Point(125, 32);
            this.lstNombreLocalidad.Name = "lstNombreLocalidad";
            this.lstNombreLocalidad.Size = new System.Drawing.Size(122, 21);
            this.lstNombreLocalidad.TabIndex = 10;
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(125, 6);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(122, 20);
            this.mtbFecha.TabIndex = 8;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(172, 112);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(91, 112);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(8, 87);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.AutoSize = true;
            this.lblNombreCultivo.Location = new System.Drawing.Point(8, 61);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCultivo.TabIndex = 11;
            this.lblNombreCultivo.Text = "Nombre de Cultivo:";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(8, 35);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(111, 13);
            this.lblNombreLocalidad.TabIndex = 9;
            this.lblNombreLocalidad.Text = "Nombre de Localidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 144);
            this.Controls.Add(this.mtbCantidad);
            this.Controls.Add(this.lstNombreCultivo);
            this.Controls.Add(this.lstNombreLocalidad);
            this.Controls.Add(this.mtbFecha);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.ComboBox lstNombreCultivo;
        private System.Windows.Forms.ComboBox lstNombreLocalidad;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblFecha;
    }
}