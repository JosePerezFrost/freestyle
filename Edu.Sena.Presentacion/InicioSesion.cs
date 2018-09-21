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
using System.Data.SqlClient;

namespace Edu.Sena.Presentacion
{
    public partial class InicioSesion : Form
    {
        Login l = new Login();
        public string sentencia;
        public SqlCommand comando;
        public SqlDataReader lector;
        public DataTable tabla;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            if (txtCedula.Text =="")
            {
                MessageBox.Show("ingrese la cedula");
            }
            else
            {
                if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Ingrese la contraseña");
                }
                else
                {
                    Login l = new Login();
                    DataTable ta = l.ingresar(Convert.ToInt64(txtCedula.Text), txtContraseña.Text);
                    if (ta != null)
                    {

                        DataRow tab = ta.Rows[0];
                        int rol = Convert.ToInt32(tab["idRol"].ToString());
                        if (rol == 1)
                        {
                            MessageBox.Show("Administrador");
                        }
                        else if (rol == 2)
                        {
                            MessageBox.Show("Participante");
                        }
                        else if (rol == 3)
                        {
                            MessageBox.Show("Jurado");
                        }
                    }else
                    {
                        MessageBox.Show("La cedula o la contraseña es incorrecta");
                    }
                }
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }
    }
}
