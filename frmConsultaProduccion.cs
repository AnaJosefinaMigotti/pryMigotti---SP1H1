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
    public partial class frmConsultaProduccion : Form
    {
        public frmConsultaProduccion()
        {
            InitializeComponent();
        }

        private void btnSalirCVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCVentas_Click(object sender, EventArgs e)
        {
            dgvConsultaProduccion.Rows.Clear(); 
        }

        private void btnListarCVentas_Click(object sender, EventArgs e)
        {
            StreamReader Produccion = new StreamReader("./Produccion.txt");
            while (!Produccion.EndOfStream)
            {
                string DatoProduccion = Produccion.ReadLine();
                string[] vecDatosProduccion = DatoProduccion.Split(',');
                dgvConsultaProduccion.Rows.Add(vecDatosProduccion[0], vecDatosProduccion[1], vecDatosProduccion[2], vecDatosProduccion[3]);
            }
            Produccion.Close();
        }
    }
}
