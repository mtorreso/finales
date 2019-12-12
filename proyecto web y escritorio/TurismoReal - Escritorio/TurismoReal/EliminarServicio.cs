﻿using System;
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
    public partial class EliminarServicio : Form
    {
        public EliminarServicio()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=portafolio ; USER ID= portafolio;");

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM SERVICIO WHERE ID_SRV = '" + txt_id.Text + "'", conexion);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("DELETE servicio WHERE id_srv='" + txt_id.Text + "'", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio Eliminado Corractamente");
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error..." + error.Message);
                conexion.Close();


            }
        }
    }
}