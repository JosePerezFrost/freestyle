using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Sena.Datos;

namespace Edu.Sena.Logica
{
    public class FaseTorneo
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

        public void registrarFase(string name)
        {

            Conexion.Conectar();
            string agg = "INSERT INTO fasestorneos(nombreFas) VALUES('" + name + "')";
            Conexion.Ejecutar(agg);
        }

    }
}
