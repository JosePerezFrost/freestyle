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
    public partial class TorneosActivos : Form
    {
        Form1 f = new Form1();
        Torneo torneo = new Torneo();
        int idTor = 0;

        public int IdTor { get => idTor; set => idTor = value; }

        public TorneosActivos()
        {
            InitializeComponent();
        }

        private void registrarTorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f.registrarTorneoToolStripMenuItem1_Click(sender, e);
            this.Hide();
        }

        private void TorneosActivos_Load(object sender, EventArgs e)
        {

            tableTorneos.DataSource = torneo.torneosActivos();

        }


        private void tableTorneos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable da = torneo.torneosActivos();
            int coun = da.Rows.Count;

            DataRow d = da.Rows[e.RowIndex];
            idTor = Convert.ToInt32(d["idTorneo"].ToString());
            MessageBox.Show(idTor.ToString());

            Participantes p = new Participantes();
               p.Show();
               this.Hide();
        }
    }
}
