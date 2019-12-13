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
    public partial class Funcionario : Form
    {
        public Funcionario(String nombre)
        {
            InitializeComponent();
            lblNombre.Text = nombre;

        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void CheckinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIN datos = new CheckIN();
            datos.Show();
        }

        private void CheckOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckOut datos = new CheckOut();
            datos.Show();
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BuscarCheckINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCheckIN datos = new BuscarCheckIN();
            datos.Show();

        }

        private void BuscarCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCheckOut datos = new BuscarCheckOut();
            datos.Show();
        }
    }
}
