using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mantenedorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto();
            pro.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mantenedorTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tecnico tec = new Tecnico();
            tec.llenar_tabla();

            tec.ShowDialog();
        }

        private void manteneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Piezas pie = new Piezas();
            pie.Show();
        }

        private void mantenedorClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cliente pro = new Cliente();
            pro.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenedorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedor vend = new Vendedor();
            vend.Show();
        }

        private void mantenedorAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen alm = new Almacen();
            alm.ShowDialog();
        }

        private void mantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen alm = new Almacen();
            alm.ShowDialog();
        }

        private void mantenedorCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas ci = new Citas();
            ci.ShowDialog();

        }
    }
}
