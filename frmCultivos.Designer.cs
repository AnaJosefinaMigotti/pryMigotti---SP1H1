namespace pryMigotti___SP1H1
{
    partial class frmCultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCultivos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtbIdentificacionCultivo = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombreCultivo = new System.Windows.Forms.TextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(102, 62);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mtbIdentificacionCultivo
            // 
            this.mtbIdentificacionCultivo.Location = new System.Drawing.Point(91, 8);
            this.mtbIdentificacionCultivo.Mask = "99999";
            this.mtbIdentificacionCultivo.Name = "mtbIdentificacionCultivo";
            this.mtbIdentificacionCultivo.Size = new System.Drawing.Size(163, 20);
            this.mtbIdentificacionCultivo.TabIndex = 21;
            this.mtbIdentificacionCultivo.ValidatingType = typeof(int);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(11, 11);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion.TabIndex = 26;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(179, 62);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreCultivo
            // 
            this.txtNombreCultivo.Location = new System.Drawing.Point(63, 34);
            this.txtNombreCultivo.Name = "txtNombreCultivo";
            this.txtNombreCultivo.Size = new System.Drawing.Size(191, 20);
            this.txtNombreCultivo.TabIndex = 23;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(11, 37);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 22;
            this.lblNombre2.Text = "Nombre:";
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 95);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mtbIdentificacionCultivo);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreCultivo);
            this.Controls.Add(this.lblNombre2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mtbIdentificacionCultivo;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombreCultivo;
        private System.Windows.Forms.Label lblNombre2;
    }
}