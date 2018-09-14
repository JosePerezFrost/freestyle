using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    public class Batalla
    {
        private int idBatalla;
        private DateTime fechaBatalla;

        private List<Participante> participantes;
        private Torneo torneo;
        private FaseTorneo fase;

        public int IdBatalla { get => idBatalla; set => idBatalla = value; }
        public DateTime FechaBatalla { get => fechaBatalla; set => fechaBatalla = value; }
        internal List<Participante> Participantes { get => participantes; set => participantes = value; }
        internal FaseTorneo Fase { get => fase; set => fase = value; }
        internal Torneo Torneo { get => torneo; set => torneo = value; }

        public Batalla()
        {
        }

        
    }
}
