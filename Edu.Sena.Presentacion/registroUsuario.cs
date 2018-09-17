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
            c.llenarItemCiudad(cbCiudad);
            c.llenarItemRol(cbROL);
            c.llenarItemGenero(cbGenero);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
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
                                                u.Cedula = int.Parse(txtCedula.Text);
                                                u.Nombres = Convert.ToString(txtNombre.Text);
                                                u.Apellidos = Convert.ToString(txtApellido.Text);
                                                u.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
                                                u.Celular = int.Parse(txtCelular.Text);
                                                u.Correo = Convert.ToString(txtCorreo.Text);
                                                u.NombreArtistico = Convert.ToString(txtNombreArtistico.Text);
                                                u.Ciudad = Convert.ToInt32(cbCiudad.ValueMember);
                                                u.Genero = Convert.ToInt32(cbCiudad.ValueMember);
                                                u.Rol = Convert.ToInt32(cbGenero.ValueMember);
                                                u.insertar();
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
