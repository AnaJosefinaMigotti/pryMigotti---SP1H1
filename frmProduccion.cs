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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //agrego a las listas desplegables los datos
            //que transcribí anteriormente en el archivo .txt

            //primero con los datos de las localidades
            StreamReader IDLocalidad = new StreamReader("./Localidades.txt");
            while (!IDLocalidad.EndOfStream)
            {
                string varIDLocalidad = IDLocalidad.ReadLine();
                //agrego los datos a un vector y los separo usando split(,)
                string[] vIDLocalidad = varIDLocalidad.Split(',');
                //muestro en la lista desplegable los datos q ingresé en
                //el vector en la posición 0
                lstNombreLocalidad.Items.Add(vIDLocalidad[0]);
            }
            IDLocalidad.Close();

            //repito con los cultivos
            StreamReader IDCultivos = new StreamReader("./Cultivos.txt");
            while (!IDCultivos.EndOfStream)
            {
                string varIDCultivos = IDCultivos.ReadLine();
                //agrego los datos a un vector y los separo usando split(,)
                string[] vIDCultivos = varIDCultivos.Split(',');
                //muestro en la lista desplegable los datos q ingresé en
                //el vector en la posición 0
                lstNombreCultivo.Items.Add(vIDCultivos[0]);
            }
            IDCultivos.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            StreamWriter Produccion = new StreamWriter("./Produccion.txt", true);
            Produccion.WriteLine(mtbFecha.Text + "," + lstNombreLocalidad.SelectedIndex + "," + lstNombreCultivo.SelectedIndex + "," + mtbCantidad.Text);
            MessageBox.Show("Los datos han sido cargado con éxito.");
            Produccion.Close();
            mtbFecha.Text = "";
            lstNombreLocalidad.SelectedIndex = 0;
            lstNombreCultivo.SelectedIndex = 0;
            mtbCantidad.Text = "";
        }
    }
}
