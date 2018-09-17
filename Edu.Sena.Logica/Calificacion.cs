using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    public class Calificacion
    {
        private int idCalificacion;
        private int puntuacion;
        private Participante participante;
        private Torneo torneo;

        public int IdCalificacion { get => idCalificacion; set => idCalificacion = value; }
        public Torneo Torneo { get => torneo; set => torneo = value; }
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
        internal Participante Participante { get => participante; set => participante = value; }
    }
}
