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
    public partial class Participantes : Form
    {
        Participante par = new Participante();
        int idTorneo = 0;
        public Participantes()
        {
            InitializeComponent();
        }

        public Participantes(int idTor)
        {
            InitializeComponent();
            this.idTorneo = idTor;
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

        private void Participantes_Load(object sender, EventArgs e)
        {
            if (idTorneo != 0)
            {
                tableParticipantes.DataSource = par.participantesTorneo(idTorneo);

            }else
            {
                tableParticipantes.DataSource = par.consultarTodo();
                lblParticipante.Text = "Participantes Activos";
            }
        }

        private void nuevaBatallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarBatalla r = new RegistrarBatalla();
            r.Show();
            this.Hide();
        }
    }
}
