namespace pryMigotti___SP1H1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mentenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produccónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentenimientoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mentenimientoToolStripMenuItem
            // 
            this.mentenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cultivoToolStripMenuItem,
            this.cultivoToolStripMenuItem1,
            this.produccónToolStripMenuItem});
            this.mentenimientoToolStripMenuItem.Name = "mentenimientoToolStripMenuItem";
            this.mentenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mentenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadToolStripMenuItem,
            this.cultivoToolStripMenuItem2,
            this.producciónToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cultivoToolStripMenuItem
            // 
            this.cultivoToolStripMenuItem.Name = "cultivoToolStripMenuItem";
            this.cultivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cultivoToolStripMenuItem.Text = "Localidad";
            this.cultivoToolStripMenuItem.Click += new System.EventHandler(this.cultivoToolStripMenuItem_Click);
            // 
            // cultivoToolStripMenuItem1
            // 
            this.cultivoToolStripMenuItem1.Name = "cultivoToolStripMenuItem1";
            this.cultivoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cultivoToolStripMenuItem1.Text = "Cultivo";
            this.cultivoToolStripMenuItem1.Click += new System.EventHandler(this.cultivoToolStripMenuItem1_Click);
            // 
            // produccónToolStripMenuItem
            // 
            this.produccónToolStripMenuItem.Name = "produccónToolStripMenuItem";
            this.produccónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produccónToolStripMenuItem.Text = "Producción";
            this.produccónToolStripMenuItem.Click += new System.EventHandler(this.produccónToolStripMenuItem_Click);
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadToolStripMenuItem.Text = "Localidad";
            this.localidadToolStripMenuItem.Click += new System.EventHandler(this.localidadToolStripMenuItem_Click);
            // 
            // cultivoToolStripMenuItem2
            // 
            this.cultivoToolStripMenuItem2.Name = "cultivoToolStripMenuItem2";
            this.cultivoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cultivoToolStripMenuItem2.Text = "Cultivo";
            this.cultivoToolStripMenuItem2.Click += new System.EventHandler(this.cultivoToolStripMenuItem2_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.producciónToolStripMenuItem.Text = "Producción";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 240);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mentenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produccónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

