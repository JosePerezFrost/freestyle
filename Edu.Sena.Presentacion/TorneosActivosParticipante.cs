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
    public partial class TorneosActivosParticipante : Form
    {
        Torneo torneo = new Torneo();
        int idTor = 0;
        public TorneosActivosParticipante()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TorneosActivosParticipante t = new TorneosActivosParticipante();
            t.Show();
            this.Hide();
        }

        private void tableTorneos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable da = torneo.torneosActivos();
            DataRow d = da.Rows[e.RowIndex];
            idTor = Convert.ToInt32(d["idTorneo"].ToString());

            InformacionTorneo i = new InformacionTorneo(idTor);
            i.Show();
            this.Hide();

        }

        private void TorneosActivosParticipante_Load(object sender, EventArgs e)
        {
            tableTorneos.DataSource = torneo.torneosActivos();
        }
    }
}
