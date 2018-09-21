using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Edu.Sena.Datos;
using System.Data.SqlClient;

namespace Edu.Sena.Logica
{
   public  class Participante : Usuario
    {
        private string nombreArtistico;
        private List<Calificacion> calificaciones;
        Conexion c = new Conexion();

        public string Nombreartistico { get => nombreArtistico; set => nombreArtistico = value; }
        internal List<Calificacion> Calificaciones { get => calificaciones; set => calificaciones = value; }

        public Participante()
        {
        }

        public Participante(string nombreArtistico)
        {
            this.nombreArtistico = nombreArtistico;
        }

        public DataTable participantesTorneo(int idTorneo)
        {
            
            string consulta = "Select usuarios.cedula, usuarios.nombres,usuarios.apellidos,usuarios.nombreArtistico," +
                "genero.tipo FROM  " +
                "((usuarios INNER JOIN genero ON usuarios.idGenero = genero.idGenero) " +
                "INNER JOIN participantes_has_torneos ON participantes_has_torneos.cedulaParticpante = usuarios.cedula " +
                "INNER JOIN torneos ON torneos.idTorneo = participantes_has_torneos.idTorneo) " +
                "WHERE participantes_has_torneos.idEstadoParticipante = 1  " +
                "AND torneos.idTorneo =" + idTorneo;
            SqlCommand cmd = new SqlCommand( consulta, c.conecte());
            DataTable d = new DataTable();
            d.Load(cmd.ExecuteReader());
            return d;
        }

        public DataTable consultarTodo()
        {
            string consulta = "Select usuarios.cedula, usuarios.nombres,usuarios.apellidos,usuarios.nombreArtistico," +
                "genero.tipo FROM usuarios " +
                "INNER JOIN genero ON usuarios.idGenero = genero.idGenero " +
                "INNER JOIN roles ON usuarios.idRol = roles.idRol " +
                "WHERE usuarios.idRol = 2";
            SqlCommand cmd = new SqlCommand(consulta, c.conecte());
            DataTable d = new DataTable();
            d.Load(cmd.ExecuteReader());
            return d;
        }

        public Boolean inscribirTorneo(int idTor)
        {
            string q = "INSERT INTO[dbo].[participantes_has_torneos]" +
        "([idTorneo],[cedulaParticpante],[idFaseTorneo],[idEstadoParticipante])" +
    "VALUES("+idTor+",1013678921,1,1)";
            SqlCommand cmd = new SqlCommand(q, c.conecte());
            int res = cmd.ExecuteNonQuery();
            if (res == 1 )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
