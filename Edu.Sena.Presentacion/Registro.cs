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
    public partial class Registro : Form
    {
        Usuario u = new Usuario();  
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet3.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.db_sifreestyleDataSet3.ciudades);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet2.genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.db_sifreestyleDataSet2.genero);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet1.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.db_sifreestyleDataSet1.roles);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCed.Text == "")
            {
                MessageBox.Show("Ingrese la cedula");
            }
            else if (txtNombres.Text == "")
            {
                MessageBox.Show("Ingrese sus nombres");
            }
            else if (txtApellidos.Text =="")
            {
                MessageBox.Show("Ingrese sus apellidos");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Ingrese la fecha de nacimiento");

            }
            else if (txtCelular.Text == "")
            {
                MessageBox.Show("Ingrese su celular");

            }
            else if (txtCorreo.Text=="")
            {
                MessageBox.Show("Ingrese su correo");

            }
            else if (txtNombreArtistico.Text == "")
            {
                MessageBox.Show("Ingrese su nombre artistico");

            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña");

            }
            else if (cbRol.Text == "")
            {
                MessageBox.Show("Ingrese el rol");

            }
            else if (cbCiudad.Text == "")
            {
                MessageBox.Show("Ingrese su ciudad");

            }
            else if (cbGenero.Text == "")
            {
                MessageBox.Show("Ingrese su genero");

            }
            else  
            {
                u.insertar(Convert.ToInt64(txtCed.Text), txtNombres.Text, txtApellidos.Text, Convert.ToInt64(txtCelular.Text),
                    txtCorreo.Text, txtNombreArtistico.Text, txtContraseña.Text, Convert.ToInt32(cbRol.SelectedValue), Convert.ToInt32(cbCiudad.SelectedValue), Convert.ToInt32(cbGenero.SelectedValue) );
                MessageBox.Show("Se ha registrado correctamente");
                InicioSesion i = new InicioSesion();
                i.Show();
                this.Hide();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioSesion i = new InicioSesion();
            i.Show();
            this.Hide();
        }
    }
}
