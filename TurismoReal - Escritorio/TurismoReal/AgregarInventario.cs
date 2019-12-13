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
    public partial class AgregarInventario : Form
    {
        public AgregarInventario()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();


                OracleCommand comando = new OracleCommand("INSERT INTO INVENTARIO VALUES('" + "', '" + txt_id_dpto.Text + "', '" + txtProducto.Text + "', '" + cbxCantidad.Text + "', '" + cbxEstado.Text + "', '"+ rtxtDescripcion.Text + "', '" + cbxCategoria.Text +  "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Insertado");
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al ingresar usuario" + error.Message);
                conexion.Close();

            }

        }
    }
}
