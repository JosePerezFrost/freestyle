using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Edu.Sena.Datos
{
    public class Conexion
    {
        public static SqlConnection cadena;
        public static SqlCommand comando;
        public static SqlDataReader lecturaDatos;
        public static DataTable Tabla;
        public string cadenaConexion;
        public string _mensaje;
 

        public static void Conectar()
        {
            cadena = new SqlConnection(@"Data Source=SALAZARNICOLAS\SQLEXPRESS;Initial Catalog=db_sifreestyle;Integrated Security=True");
            comando = new SqlCommand();
            comando.Connection = cadena;
        }
        public static void Ejecutar(string Sentencia)
        {
            Conectar();
            comando.CommandText = Sentencia;
            cadena.Open();
            comando.ExecuteNonQuery();
            cadena.Close();
        }
        public static DataTable consultar(string Sentencia)
        {
            Conectar();
            comando.CommandText = Sentencia;
            cadena.Open();
            lecturaDatos = comando.ExecuteReader();
            Tabla = new DataTable();
            Tabla.Load(lecturaDatos);
            lecturaDatos.Close();
            return Tabla;
        }
        private string con = @"Data Source=SALAZARNICOLAS\SQLEXPRESS;Initial Catalog=db_sifreestyle;Integrated Security=True";
        public string Cnn
        {
            get { return con; }
            set { value = con; }
        }

        public SqlConnection conecte()
        {
            try
            {
                cadena = new SqlConnection(Cnn);
                cadena.Open();
                return cadena;
            }
            catch (SqlException ex)
            {
                cadena.Close();
                return cadena;
            }
        }
    }
}
