using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class Participante : Usuario
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
    }
}
