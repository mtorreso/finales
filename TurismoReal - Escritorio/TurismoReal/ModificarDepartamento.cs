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
    public partial class ModificarDepartamento : Form
    {
        public ModificarDepartamento()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM DEPARTAMENTO WHERE ID = '" + txtID.Text + "'", conexion);
                OracleDataAdapter oda = new OracleDataAdapter(comando);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dgbLista.DataSource = ds.Tables[0];
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
                OracleCommand comando = new OracleCommand("UPDATE DEPARTAMENTO SET NOMBRE='" + txtDepto.Text + "',UBICACION= '" + cbxUbicacion.Text + "',BANOS= '" + txtBanos.Text + "',HABITACIONES= '" + txtHabitaciones.Text + "',VALORARRIENDO= '" + txtValor_arriendo.Text + "',DESCRIPCION= '" + rtxtDescripcion.Text + "',FECHA='" + dtmCalendar.Value + "',DIRECCION='" + txtDireccion.Text + "',HABILITADO='" + cbxHabilitado.Text + "',WHERE ID ='" +txtID.Text + "'", conexion);
                
                comando.ExecuteNonQuery();
                MessageBox.Show("Departamento Actualizado");
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("error" + error.Message);
                conexion.Close();

            }
        }

        public DataTable Datos()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM LOCALIDAD";
            OracleCommand command = new OracleCommand(query, conexion);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;



        }

        private void ModificarDepartamento_Load(object sender, EventArgs e)
        {
            cbxUbicacion.DataSource = Datos();
            cbxUbicacion.DisplayMember = "NOMBRE_LOCALIDAD"; //campo que queres mostrar
            cbxUbicacion.ValueMember = "Id_LOCALIDAD"; //valor que capturas
        }
    }
}
