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
using Edu.Sena.Datos;
using System.Data.SqlClient;

namespace Edu.Sena.Presentacion
{
    public partial class registroUsuario : Form
    {
        llenarComboBox c = new llenarComboBox();
        Usuario u = new Usuario();

        public registroUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login menu = new Login();
            menu.Show();
            this.Hide();
        }

        private void registroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet4.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.db_sifreestyleDataSet4.roles);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet3.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.db_sifreestyleDataSet3.ciudades);
            // TODO: esta línea de código carga datos en la tabla 'db_sifreestyleDataSet2.genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.db_sifreestyleDataSet2.genero);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (Cedula.Text == "")
            {
                MessageBox.Show("Ingrese la cedula");
            }
            else
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese su nombre");
                }
                else
                {
                    if (txtApellido.Text == "")
                    {
                        MessageBox.Show("Ingrese sus apellidos");
                    }
                    else
                    {
                        if (cbGenero.Text == "")
                        {
                            MessageBox.Show("Seleccione su  genero");
                        }
                        else
                        {
                            if (txtCelular.Text == "")
                            {
                                MessageBox.Show("Ingrese su  celular");

                            }
                            else
                            {
                                if (txtCorreo.Text == "")
                                {
                                    MessageBox.Show("Ingrese su  Correo");

                                }
                                else
                                {
                                    if (txtNombreArtistico.Text == "")
                                    {
                                        MessageBox.Show("ingrese su  nombre artistico");
                                    }
                                    else
                                    {
                                        if (cbCiudad.Text == "")
                                        {
                                            MessageBox.Show("Seleccione su  ciuduad");
                                        }
                                        else
                                        {
                                            if (cbROL.Text == "")
                                            {
                                                MessageBox.Show("Seleccione su rol");
                                            }
                                            else
                                            {
                                                u.insertar(Convert.ToInt64(Cedula.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt64(txtCelular.Text), txtCorreo.Text, txtNombreArtistico.Text, txtContraseña.Text, Convert.ToInt32(cbROL.SelectedValue), Convert.ToInt32(cbCiudad.SelectedValue), Convert.ToInt32(cbGenero.SelectedValue));
                                                MessageBox.Show("Se ha registrado correctamente");
                                                Login menu = new Login();
                                                menu.Show();
                                                this.Hide();

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
