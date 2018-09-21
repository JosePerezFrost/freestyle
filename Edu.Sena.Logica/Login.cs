using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Edu.Sena.Datos;

namespace Edu.Sena.Logica
{
    public class Login : Conexion
    {
        public SqlDataReader lector;
        public SqlCommand comand;

      /* public String Rol1(long usuario, string clave)
        {
            try
            {
                comand = new SqlCommand("select * from usuarios where usuarios.idRol = 1 and usuarios.contraseña = '" + clave + "' and usuarios.cedula = '" + usuario + "'", conecte());
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    return lector[0].ToString();
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrecta");
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
        public String Rol2(long usuario, string clave)
        {
            try
            {
                comand = new SqlCommand("select * from usuarios where usuarios.idRol = 2 and usuarios.contraseña = '" + clave + "' and usuarios.cedula = '" + usuario + "'", conecte());
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    return lector[0].ToString();
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrecta");
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
        public String Rol3(long usuario, string clave)
        {
            try
            {
                comand = new SqlCommand("select * from usuarios where usuarios.idRol = 3 and usuarios.contraseña = '" + clave + "' and usuarios.cedula = '" + usuario + "'", conecte());
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    return lector[0].ToString();
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrecta");
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }*/

    public DataTable ingresar (long id, string clave)
        {
            string consulta = "SELECT * FROM usuarios WHERE cedula=" + id + " and contraseña='"+clave+"'";
            SqlCommand comand = new SqlCommand(consulta, conecte());
            DataTable t = new DataTable();
            t.Load(comand.ExecuteReader());
            if (t.Rows.Count >0)
            {
                return t;

            }
            else
            {
                return null;
            }
        }        
    }
}
