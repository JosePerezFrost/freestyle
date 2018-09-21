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
    public partial class PerfilParticipante : Form
    {
        public PerfilParticipante()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TorneosActivosParticipante t = new TorneosActivosParticipante();
            t.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void PerfilParticipante_Load(object sender, EventArgs e)
        {
            Torneo t = new Torneo();
            DataTable d = t.torneosActivos();
            int torA = d.Rows.Count;
            lblTorneosActivos.Text = torA.ToString();
        }
    }
}
