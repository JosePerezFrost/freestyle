using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class Torneo
    {
        private int idTorneo;
        private int cupos;
        private string nombreTorneo;
        private string lugar;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime horaInicio;
        private TipoTorneo tipo;
        private Estado estado;
        /*Agg al D.clases*/
        private Ciudad ciudadRealizacion;
        private List<Usuario> usuarios;
        private List<FaseTorneo> fases;

        public int IdTorneo { get => idTorneo; set => idTorneo = value; }
        public int Cupos { get => cupos; set => cupos = value; }
        public string NombreTorneo { get => nombreTorneo; set => nombreTorneo = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TipoTorneo Tipo { get => tipo; set => tipo = value; }
        public Estado Estado { get => estado; set => estado = value; }
        internal Ciudad CiudadRealizacion { get => ciudadRealizacion; set => ciudadRealizacion = value; }
        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal List<FaseTorneo> Fases { get => fases; set => fases = value; }

    }
}
