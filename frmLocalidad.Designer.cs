namespace pryMigotti___SP1H1
{
    partial class frmLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidad));
            this.mtbIdentificacionLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbIdentificacionLocalidad
            // 
            this.mtbIdentificacionLocalidad.Location = new System.Drawing.Point(91, 7);
            this.mtbIdentificacionLocalidad.Mask = "99999";
            this.mtbIdentificacionLocalidad.Name = "mtbIdentificacionLocalidad";
            this.mtbIdentificacionLocalidad.Size = new System.Drawing.Size(164, 20);
            this.mtbIdentificacionLocalidad.TabIndex = 15;
            this.mtbIdentificacionLocalidad.ValidatingType = typeof(int);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(8, 10);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificador.TabIndex = 21;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // btnSalir1
            // 
            this.btnSalir1.Location = new System.Drawing.Point(99, 61);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(75, 23);
            this.btnSalir1.TabIndex = 20;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(180, 61);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(65, 35);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(190, 20);
            this.txtNombreLocalidad.TabIndex = 17;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(8, 36);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(47, 13);
            this.lblNombre1.TabIndex = 16;
            this.lblNombre1.Text = "Nombre:";
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 94);
            this.Controls.Add(this.mtbIdentificacionLocalidad);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.lblNombre1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbIdentificacionLocalidad;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblNombre1;
    }
}