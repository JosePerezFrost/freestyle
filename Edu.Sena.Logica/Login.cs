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
        

        public String Rol1(string usuario, string clave)
        {
            try
            {
                Conexion.comando = new SqlCommand("select * from usuarios where usuarios.idRol = 1 and usuarios.contraseña = '" + clave + "' and usuarios.cedula = '" + usuario + "'", conecte());
                Conexion.lecturaDatos = comando.ExecuteReader();
                if (Conexion.lecturaDatos.Read())
                {
                    return Conexion.lecturaDatos[0].ToString();
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
        public String rol2(string usuario, string clave)
        {
            try
            {
                Conexion.comando= new SqlCommand("select * from usuarios where usuarios.idRol = 2 and usuarios.contraseña = '" + clave + "' and usuarios.cedula = '" + usuario + "'", conecte());
                Conexion.lecturaDatos = comando.ExecuteReader();
                if (Conexion.lecturaDatos.Read())
                {
                  return Conexion.lecturaDatos[0].ToString();
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
    }
}
