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
    public partial class AgregarUsuario : Form
    {

        
        public AgregarUsuario()
        {
            InitializeComponent();

        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                
                conexion.Open();
                OracleCommand comando1 = new OracleCommand("SELECT ID_ROL FROM ROL WHERE DESCRIPCION = '" + cbxRoles.Text + "'");
                OracleCommand comando = new OracleCommand("INSERT INTO USUARIO VALUES('"+ "', '" + txtRut.Text + "', '" + txtNombre.Text + "', '" + txtCorreo.Text + "', '" + txtTelefono.Text + "', '" + cbxRoles.Text + "', '" + cbxRoles.Text + "')", conexion);
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
