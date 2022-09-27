using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMigotti___SP1H1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cultivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad objlocalidad = new frmLocalidad();
            objlocalidad.ShowDialog();
                
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaLocalidad objConsultaLocalidad = new frmConsultaLocalidad();
            objConsultaLocalidad.ShowDialog();
        }

        private void cultivoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaCultivos objConsultaCultivos = new frmConsultaCultivos();
            objConsultaCultivos.ShowDialog();
        }

        private void cultivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCultivos objCultivos = new frmCultivos();
            objCultivos.ShowDialog();
        }

        private void produccónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion objProduccion = new frmProduccion();
            objProduccion.ShowDialog();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProduccion objConsultaProduccion = new frmConsultaProduccion();
            objConsultaProduccion.ShowDialog();
        }
    }
}
