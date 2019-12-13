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
    public partial class BuscarServicio : Form
    {
        public BuscarServicio()
        {
            InitializeComponent();
        }

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM SERVICIO WHERE NOMBRE_SRV = '" + txtServicio.Text + "'", conexion);
                OracleDataAdapter oda = new OracleDataAdapter(comando);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dgbListar.DataSource = ds.Tables[0];
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);

            }

        }
    }
}
