using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMigotti___SP1H1
{
    public partial class frmConsultaLocalidad : Form
    {
        public frmConsultaLocalidad()
        {
            InitializeComponent();
        }

        private void btnSalirCClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCClientes_Click(object sender, EventArgs e)
        {
            dgvConsultaLocalidad.Rows.Clear();
        }

        private void btnListarCClientes_Click(object sender, EventArgs e)
        {
            StreamReader Localidad = new StreamReader("./Localidades.txt");
            while (!Localidad.EndOfStream)
            {
                string DatoLocalidad = Localidad.ReadLine();
                string[] vecDatosLocalidad = DatoLocalidad.Split(',');
                dgvConsultaLocalidad.Rows.Add(vecDatosLocalidad[0], vecDatosLocalidad[1]);
            }
            Localidad.Close();
        }
    }
}
