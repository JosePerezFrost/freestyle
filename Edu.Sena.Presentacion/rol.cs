using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Sena.Datos;
using System.Data.SqlClient;

namespace Edu.Sena.Presentacion
{
    public partial class rol : Form
    {
        public rol()
        {
            InitializeComponent();

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (rl.Text == "")
            {
                MessageBox.Show("Digite el rol");
            }
            else
            {

            string rolj = rl.Text;
            Conexion.Ejecutar("Insert into roles(tipo) values ('" + rolj + "')");
            MessageBox.Show("Bien hecho");
            rl.Text = "";
            Conexion.cadena.Close();

            }
        }
    }
}
