using System;
using System.Collections.Generic;
using Edu.Sena.Datos;
using System.Data.SqlClient;

namespace Edu.Sena.Logica
{
    public class Usuario
    {
        private long cedula;
        private string nombres;
        private string apellidos;
        private long celular;
        private string correo;
        private DateTime fechaNacimiento;
        /*Corregir en el D.Clases*/
       // private char genero;
        private string contrasena;
        private string nombreArtistico;
        private int ciudad;
        private int rol;
        private int genero;
      //  private Ciudad ciudad;
       // private List<Rol> rol;
        private List<Torneo> torneosParticipados;
        private List<Batalla> batallasAsistidas;
        private string sentencia;
        public long Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public long Celular { get => celular; set => celular = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Genero { get => genero; set => genero = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Ciudad { get => ciudad; set => ciudad = value; }
        public string NombreArtistico { get => nombreArtistico; set => nombreArtistico = value; }
        public List<Batalla> BatallasAsistidas { get => batallasAsistidas; set => batallasAsistidas = value; }
        public int Rol { get => rol; set => rol = value; }
        internal List<Torneo> TorneosParticipados { get => torneosParticipados; set => torneosParticipados = value; }


        public void insertar(long cedula, string nombre, string apellido, long celular, string correo, string nombreArtis, string clave, int idRol, int idCiu, int idGen)
        {
            Conexion c = new Conexion();
            string sentencia = "  insert into usuarios values (" + cedula + ",'"+nombre+"','"+apellido+"','1999-05-01', "+celular+" ,'"+correo+"','"+nombreArtis+"','"+clave+"',"+idRol+","+idCiu+","+idGen+")";
            SqlCommand comand = new SqlCommand(sentencia, c.conecte());
            comand.ExecuteNonQuery();
        }


    }
}
