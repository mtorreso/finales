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
    public partial class ModicarUsuario : Form
    {
        public ModicarUsuario()
        {
            InitializeComponent();
        }

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE RUT like '" + txtRut.Text + "'", conexion);
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

        private void DgbListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgbListar.Rows[e.RowIndex];
            txtRut1.Text = dgv.Cells[0].Value.ToString();
            txtNombre.Text = dgv.Cells[1].Value.ToString();
            txtCorreo.Text = dgv.Cells[2].Value.ToString();
            txtTelefono.Text = dgv.Cells[3].Value.ToString();
            txtClave.Text = dgv.Cells[4].Value.ToString();
            cbxRol.Text = dgv.Cells[5].Value.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("UPDATE USUARIO SET RUT='" + txtRut1.Text + "',NOMBRE='" + txtNombre.Text + "',CORREO='"+txtCorreo.Text+"',TELEFONO='"+txtTelefono.Text+"',CLAVE='"+txtClave.Text+"',ID_ROL='"+cbxRol.Text +"'WHERE RUT='"+txtRut.Text+"'", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Actualizado");
                conexion.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("error" + error.Message);
                conexion.Close();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
