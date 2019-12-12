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
    public partial class ModificarServicio : Form
    {
        public ModificarServicio()
        {
            InitializeComponent();
        }

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM SERVICIO WHERE Id_srv = '" + txt_id.Text + "'", conexion);
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("UPDATE SERVICIO SET NOMBRE_SRV='" + txtNombre.Text + "',PRECIO='" + txtPrecio.Text   + "'", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("SERVICIO Actualizado");
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("error" + error.Message);
                conexion.Close();

            }
        }
    }
}
