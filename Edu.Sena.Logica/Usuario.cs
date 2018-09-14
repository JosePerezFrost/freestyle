using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class Usuario
    {
        private long cedula;
        private string nombres;
        private string apellidos;
        private long celular;
        private string correo;
        private DateTime fechaNacimiento;
        /*Corregir en el D.Clases*/
        private char genero;
        private Ciudad ciudad;
        private List<Rol> rol;
        private List<Torneo> torneosParticipados;
        private List<Batalla> batallasAsistidas;

        public long Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public long Celular { get => celular; set => celular = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Genero { get => genero; set => genero = value; }
        public Ciudad Ciudad { get => ciudad; set => ciudad = value; }
        public List<Batalla> BatallasAsistidas { get => batallasAsistidas; set => batallasAsistidas = value; }
        internal List<Rol> Rol { get => rol; set => rol = value; }
        internal List<Torneo> TorneosParticipados { get => torneosParticipados; set => torneosParticipados = value; }
    }
}
