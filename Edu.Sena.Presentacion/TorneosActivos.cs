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
        public TorneosActivos()
        {
            InitializeComponent();
        }

        private void registrarTorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f.registrarTorneoToolStripMenuItem1_Click(sender,e);
            this.Hide();
        }

        private void TorneosActivos_Load(object sender, EventArgs e)
        {
            tableTorneoActivos = torneo.torneosActivos();
        }
    }
}
