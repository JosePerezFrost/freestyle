using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Sena.Logica;

namespace Edu.Sena.Presentacion
{
    public partial class Login : Form
    {
        Logica.Login sesion = new Logica.Login();

        public Login()
        {
            InitializeComponent();
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string retorno1 = sesion.Rol1(txtUsuario.Text, txtContraseña.Text);
            string retorno = sesion.rol2(txtUsuario.Text, txtContraseña.Text);
            string retorno2 = sesion.rol3(txtUsuario.Text, txtContraseña.Text);
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Ingrese su cedula");
            }else
            {
                if (txtContraseña.Text=="")
                {
                    MessageBox.Show("Ingrese la contraseña");
                }
                else
                {
                    if (retorno1 != "")
                    {
                        RegistroTorneo torneo = new RegistroTorneo();
                        torneo.Show();
                        this.Hide();
                    }
                    else if (retorno !="")
                    {
                        Form1 menu = new Form1();
                        menu.Show();
                        this.Hide();
                    }
                    else if (retorno2 !="")
                    {
                        registroUsuario r = new registroUsuario();
                        r.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("usuario o contraseña incorrectas");
                        txtContraseña.Clear();
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                    }
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registroUsuario registro = new registroUsuario();
            registro.Show();
            this.Hide();
                }
    }
}
