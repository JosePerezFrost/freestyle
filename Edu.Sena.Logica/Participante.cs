using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Edu.Sena.Datos;
namespace Edu.Sena.Logica
{
   public  class Participante : Usuario
    {
        private string nombreArtistico;
        private List<Calificacion> calificaciones;

        public string NombreArtistico { get => nombreArtistico; set => nombreArtistico = value; }
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
            Conexion.Conectar();
            string consulta = "Select usuarios.cedula, usuarios.nombres,usuarios.apellidos,usuarios.nombreArtistico," +
                "genero.tipo FROM usuarios " +
                "INNER JOIN genero ON usuarios.idGenero = genero.idGenero" +
                "INNER JOIN participantes_has_torneos ON participantes_has_torneos.cedulaParticpante = usuarios.cedula" +
                "INNER JOIN torneos ON torneos.idTorneo = participantes_has_torneos.idTorneo" +
                "WHERE participantes_has_torneos.idEstadoParticipante = 1 " +
                "AND torneos.idTorneo =" + idTorneo;
            DataTable d = Conexion.consultar(consulta);
            return d;
        }
    }
}
