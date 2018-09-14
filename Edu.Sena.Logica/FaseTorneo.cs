using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class FaseTorneo
    {
        private int idFase;
        private string nombreFase;

        public int IdFase { get => idFase; set => idFase = value; }
        public string NombreFase { get => nombreFase; set => nombreFase = value; }

        public FaseTorneo()
        {
        }

        public FaseTorneo(int idFase, string nombreFase)
        {
            this.idFase = idFase;
            this.nombreFase = nombreFase;
        }
    }
}
