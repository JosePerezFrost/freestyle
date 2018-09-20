﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Sena.Logica;

namespace Edu.Sena.Presentacion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void MenuTorneo_Click(object sender, EventArgs e)
        {
            TorneosActivos t = new TorneosActivos();
            t.Show();
            this.Hide();
        }

        public void registrarTorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroTorneo r = new RegistroTorneo();
            r.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void añadirFaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AñadirFase a = new AñadirFase();
            a.Show();
            this.Hide();
        }
    }
}
