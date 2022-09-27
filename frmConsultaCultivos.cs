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
    public partial class frmConsultaCultivos : Form
    {
        public frmConsultaCultivos()
        {
            InitializeComponent();
        }

        private void btnSalirCClientes_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnLimpiarCClientes_Click(object sender, EventArgs e)
        {
            dgvConsultaCultivo.Rows.Clear();
        }

        private void btnListarCClientes_Click(object sender, EventArgs e)
        {
            StreamReader Cultivos = new StreamReader("./Cultivos.txt");
            while (!Cultivos.EndOfStream)
            {
                string DatoCultivos = Cultivos.ReadLine();
                //split() para separar los archivos q agregué al vector
                string[] vecDatosCultivos = DatoCultivos.Split(',');
                //agrego a la grilla los datos según la posición que
                //tienen los mismos en el vector
                dgvConsultaCultivo.Rows.Add(vecDatosCultivos[0], vecDatosCultivos[1]);
            }
            Cultivos.Close();
        }
    }
}
