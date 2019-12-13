using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace TurismoReal
{
    public partial class AgregarServicio : Form
    {
        public AgregarServicio()
        {
            InitializeComponent();
        }

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERT INTO SERVICIO VALUES('" + "', '" + txtNombre.Text + "', '" + txtPrecio.Text + "', '" +txt_id.Text  + "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio Insertado");
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al ingresar el servicio" + error.Message);
                conexion.Close();

            }


        }
    }
}
