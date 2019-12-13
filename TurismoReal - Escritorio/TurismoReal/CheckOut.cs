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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERT INTO CHECKOUT VALUES('" + "', '" + dtmFecha.Text + "', '" + richTextBox1.Text + "', '" + txtReserva.Text + "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Checkout regristrado correactamente");
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error.Message);
                conexion.Close();

            }
        }
    }
}
