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
    public partial class ModificarInventario : Form
    {
        public ModificarInventario()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM INVENTARIO WHERE id_inv = '" + txtInventario.Text + "'", conexion);
                OracleDataAdapter oda = new OracleDataAdapter(comando);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dbgListar.DataSource = ds.Tables[0];
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
                OracleCommand comando = new OracleCommand("UPDATE INVENTARIO SET ID_DEPTO='" + txtID_dpto.Text + "',PRODUCTO='" + txtProducto.Text + "',CANTIDAD='" + cbxCantidad.Text + "',ESTADO='" + cbxEstado.Text + "',DESCRIPCION='" + rtxtDescripcion.Text + "',CATEGORIA='" + cbxCategoria.Text + "'WHERE ID_INV='" + txtInventario.Text + "'", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Actualizado");
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
