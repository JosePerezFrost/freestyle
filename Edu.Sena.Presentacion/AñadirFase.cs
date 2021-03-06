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
    public partial class AñadirFase : Form
    {
        public AñadirFase()
        {
            InitializeComponent();
        }

        private void añadirFaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuTorneo_Click(object sender, EventArgs e)
        {

            TorneosActivos t = new TorneosActivos();
            t.Show();
            this.Hide();
        }

        private void registrarTorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroTorneo r = new RegistroTorneo();
            r.Show();
            this.Hide();
        }

        private void btnAggFase_Click(object sender, EventArgs e)
        {
            FaseTorneo f = new FaseTorneo();
            f.registrarFase(txtNombreFase.Text);
           MessageBox.Show("Se ha registrado una nueva fase con exito");
            txtNombreFase.Text = "";

        }

        private void AñadirFase_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.fasestorneos' Puede moverla o quitarla según sea necesario.
            this.fasestorneosTableAdapter.Fill(this.db_sifreestyleDataSet.fasestorneos);

        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Participantes p = new Participantes();
            p.Show();
            this.Hide();
        }
    }
}