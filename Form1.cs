﻿using System;
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
            tec.ShowDialog();
        }
    }
}
