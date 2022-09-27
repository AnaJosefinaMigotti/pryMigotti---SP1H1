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
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //booleano v/f
            //para que el número de identificación no se repita
            bool Repetido = false;
            if (File.Exists("./Localidades.txt"))
            {
                StreamReader IDControl = new StreamReader("./Localidades.txt");
                while (!IDControl.EndOfStream)
                {
                    string varIDCliente = IDControl.ReadLine();
                    //split(,) para separar los datos que se encuentran el archivo
                    string[] Clientes = varIDCliente.Split(',');

                    //si el número por registrar coincide con la primera posición
                    //del vector creado anteriormente no podrá ser guardado
                    if (mtbIdentificacionLocalidad.Text == Clientes[0])
                    {
                        MessageBox.Show("El número ingresado ya ha sido registrado.");
                        mtbIdentificacionLocalidad.Text = "";
                        txtNombreLocalidad.Text = "";
                        //focus para q quede seleccionada la masked
                        mtbIdentificacionLocalidad.Focus();
                        Repetido = true;
                    }
                }
                IDControl.Close();
            }
            if (Repetido == false)
            {
                StreamWriter DatosClientes = new StreamWriter("./Localidades.txt", true);
                DatosClientes.WriteLine(mtbIdentificacionLocalidad.Text + "," + txtNombreLocalidad.Text);
                MessageBox.Show("Los datos de la localidad han sido registrados con éxito.");
                DatosClientes.Close();
                mtbIdentificacionLocalidad.Text = "";
                txtNombreLocalidad.Text = "";
                //focus para q quede seleccionada la masked
                mtbIdentificacionLocalidad.Focus();
            }

        }
    }
}
