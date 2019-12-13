using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public partial class Administrador : Form
    {
        public Administrador(String nombre)
        {
            InitializeComponent();
            lblNombre1.Text = nombre;
            
        }

      
        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario datos = new AgregarUsuario();
            datos.Show();
        }

        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUsuario datos = new BuscarUsuario();
            datos.Show();
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModicarUsuario datos = new ModicarUsuario();
            datos.Show();
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario datos = new EliminarUsuario();
            datos.Show();
        }

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarDepartamento datos = new AgregarDepartamento();
            datos.Show();
        }

        private void BuscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarDepartamento datos = new BuscarDepartamento();
            datos.Show();
        }

        private void ModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarDepartamento datos = new ModificarDepartamento();
            datos.Show();
        }

        private void EliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarDepartamento datos = new EliminarDepartamento();
            datos.Show();
        }

        private void AgregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AgregarInventario datos = new AgregarInventario();
            datos.Show();
        }

        private void BuscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BuscarInventario datos = new BuscarInventario();
            datos.Show();
        }

        private void ModificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModificarInventario datos = new ModificarInventario();
            datos.Show();
        }

        private void EliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarInventario datos = new EliminarInventario();
            datos.Show();
        }

        private void AgregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AgregarServicio datos = new AgregarServicio();
            datos.Show();
        }

        private void BuscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BuscarServicio datos = new BuscarServicio();
            datos.Show();
        }

        private void ModificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificarServicio datos = new ModificarServicio();
            datos.Show();
        }

        private void EliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EliminarServicio datos = new EliminarServicio();
            datos.Show();
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
