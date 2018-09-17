using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Presentacion
{
    public partial class RegistroTorneo : Form
    {
        Form1 f = new Form1();
        public RegistroTorneo()
        {
            InitializeComponent();
        }

        private void MenuTorneo_Click(object sender, EventArgs e)
        {
            f.MenuTorneo_Click(sender, e);
            this.Hide();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
