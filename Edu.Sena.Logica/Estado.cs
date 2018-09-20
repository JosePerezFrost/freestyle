using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    public class Estado
    {
        private int idEstado;
        private string nombre;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
