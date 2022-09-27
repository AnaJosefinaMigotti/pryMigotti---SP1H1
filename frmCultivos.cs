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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //booleano v/f
            //para que el número de identificación no se repita
            bool Repetido = false;
            if (File.Exists("./Cultivos.txt"))
            {
                StreamReader IDControl = new StreamReader("./Cultivos.txt");
                while (!IDControl.EndOfStream)
                {
                    string varIDCultivo = IDControl.ReadLine();
                    //split(,) para separar los datos que se encuentran el archivo
                    string[] Cultivos = varIDCultivo.Split(',');

                    //si el número por registrar coincide con la primera posición
                    //del vector creado anteriormente no podrá ser guardado
                    if (mtbIdentificacionCultivo.Text == Cultivos[0])
                    {
                        MessageBox.Show("El número ingresado ya ha sido registrado.");
                        mtbIdentificacionCultivo.Text = "";
                        txtNombreCultivo.Text = "";
                        //focus para q quede seleccionada la masked
                        mtbIdentificacionCultivo.Focus();
                        Repetido = true;
                    }
                }
                IDControl.Close();
            }
            if (Repetido == false)
            {
                StreamWriter DatosCultivos = new StreamWriter("./Cultivos.txt", true);
                DatosCultivos.WriteLine(mtbIdentificacionCultivo.Text + "," + txtNombreCultivo.Text);
                MessageBox.Show("Los datos de la localidad han sido registrados con éxito.");
                DatosCultivos.Close();
                mtbIdentificacionCultivo.Text = "";
                txtNombreCultivo.Text = "";
                //focus para q quede seleccionada la masked
                mtbIdentificacionCultivo.Focus();
            }
        }
    }
}
