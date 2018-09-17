using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Edu.Sena.Datos;

namespace Edu.Sena.Logica
{
    public class llenarComboBox : Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public void llenarItemRol(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select * from roles", conecte());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["tipo"]).ToString();
                    cb.ValueMember = dr["idRol"].ToString();
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se lleno el combo box");
            }
        }
        
        public void llenarItemCiudad(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select * from ciudades", conecte());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"]).ToString();
                    cb.ValueMember = dr["codigoCiudad"].ToString();
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("no se lleno el combo box");
            }
        }
        public void llenarItemGenero(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select * from genero", conecte());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["tipo"]).ToString();
                    cb.ValueMember = dr["idGenero"].ToString();
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se lleno el combo box");
            }
        }
    }
}
