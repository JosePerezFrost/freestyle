using System;
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
    public partial class RegistrarBatalla : Form
    {
        public RegistrarBatalla()
        {
            InitializeComponent();
        }

        private void añadirFaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AñadirFase a = new AñadirFase();
            a.Show();
            this.Hide();
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

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Participantes p = new Participantes();
            p.Show();
            this.Hide();
        }

        private void RegistrarBatalla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.db_sifreestyleDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.fasestorneos' Puede moverla o quitarla según sea necesario.
            this.fasestorneosTableAdapter.Fill(this.db_sifreestyleDataSet.fasestorneos);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.torneos' Puede moverla o quitarla según sea necesario.
            this.torneosTableAdapter.Fill(this.db_sifreestyleDataSet.torneos);

        }

        private void btnRegistrarBatalla_Click(object sender, EventArgs e)
        {
            Batalla b = new Batalla();
            b.registrarBatalla(Convert.ToInt32(cbTorneo.SelectedValue), Convert.ToInt32(cbFase.SelectedValue),
                Convert.ToDateTime(fechaBatalla.Value),Convert.ToInt64(cbParticipante1.SelectedValue), Convert.ToInt64(cbParticipante2.SelectedValue));
        }
    }
}
