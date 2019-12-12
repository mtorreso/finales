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
using System.Threading;


namespace TurismoReal
{
    public partial class AgregarDepartamento : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");
        public AgregarDepartamento()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERT INTO DEPARTAMENTO VALUES('" + "', '" + txtDepto.Text + "', '" + cbxUbicacion.Text + "', '" +txtBanos.Text + "', '" + txtHabitaciones.Text + "', '" + txtValor_arriendo.Text + "', '" + rtxtDescripcion.Text +"','"+ dtmCalendar.Value + "','" + txtDireccion.Text+"','"+cbxHabilitado.Text+ "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Departamento Insertado");
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al ingresar departamento" + error.Message);
                conexion.Close();

            }


        }

        private void AgregarDepartamento_Load(object sender, EventArgs e)
        {
            cbxUbicacion.DataSource = Datos();
            cbxUbicacion.DisplayMember = "NOMBRE_LOCALIDAD"; //campo que queres mostrar
            cbxUbicacion.ValueMember = "Id_LOCALIDAD"; //valor que capturas
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

        
        


    }
}
