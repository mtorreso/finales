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
    public partial class BuscarDepartamento : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");
        public BuscarDepartamento()
        {
            InitializeComponent();
        }

        private void BtnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM DEPARTAMENTO WHERE ID = '" + txtNombre.Text + "'", conexion);
                OracleDataAdapter oda = new OracleDataAdapter(comando);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dgbListarDpto.DataSource = ds.Tables[0];
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);

            }
        }
    }
}
