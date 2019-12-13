using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");


        public void logear(String correo, String contrasena)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("SELECT RUT,NOMBRE,TELEFONO,ID_ROL  FROM USUARIO WHERE CORREO = :correo AND CLAVE = :contra", conexion);
                comando.Parameters.AddWithValue(":correo", txtcorreo.Text);
                comando.Parameters.AddWithValue(":contra", txtclave.Text);
                OracleDataAdapter sda = new OracleDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][3].ToString() == "1")
                    {

                        new Administrador(dt.Rows[0][1].ToString()).Show();


                    }
                    else if (dt.Rows[0][3].ToString() == "2")
                    {
                        new Funcionario(dt.Rows[0][1].ToString()).Show();

                    }
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente nuevamente");
            }
            finally
            {
                conexion.Close();
            }
        }
    


        private void btnconectar_Click(object sender, EventArgs e)
        {
            logear(this.txtcorreo.Text, this.txtclave.Text);
        
        }
}
}
    

