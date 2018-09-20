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

        private void RegistroTorneo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.tipotorneo' Puede moverla o quitarla según sea necesario.
            this.tipotorneoTableAdapter.Fill(this.db_sifreestyleDataSet.tipotorneo);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.ciudades_has_torneo' Puede moverla o quitarla según sea necesario.
            this.ciudades_has_torneoTableAdapter.Fill(this.db_sifreestyleDataSet.ciudades_has_torneo);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.db_sifreestyleDataSet.ciudades);
            llenarComboBox l = new llenarComboBox();
            l.llenarChecked(listBoxFase);
            
        }

        private void listBoxFase_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Torneo t = new Torneo();
            Boolean b =t.registrarToreno(txtNombre.Text, txtLugar.Text, Convert.ToInt32(numCupos.Value), Convert.ToDateTime(dateInicio.Value), 
                Convert.ToDateTime(dateFin.Value), Convert.ToDateTime(timeHora.Value), Convert.ToInt32(cbTipo.SelectedValue), Convert.ToInt32(cbCiudad.SelectedValue));
            if (b == true)
            {
                txtNombre.Text = "";
                txtLugar.Text = "";
                numCupos.Value = 0;
                dateInicio.Value = DateTime.Today;
                dateFin.Value = DateTime.Today;
                timeHora.Value = DateTime.Now;
                
            }
                        
        }
    }
}
