using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Sena.Datos;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Edu.Sena.Logica
{
    public class Torneo
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

        Conexion c = new Conexion();

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

        public DataTable torneosActivos()
        {
            Conexion.Conectar();
            string cadena = "SELECT torneos.idTorneo,torneos.nombreTorneo ,torneos.lugar, torneos.cupos, torneos.fechaFin," +
                "  tipotorneo.tipo , estados.tipoEstado FROM((torneos" +
  " INNER JOIN tipotorneo ON torneos.idTipoTorneo = tipotorneo.idTipo)" +
   " INNER JOIN estados ON torneos.idEstado = estados.idEstado)" +
   "WHERE torneos.idEstado = 1 ";
            DataTable d = Conexion.consultar(cadena);
            return d;
        }

        public Boolean registrarToreno(string nombre, string lugar, int cupos, DateTime fIni, DateTime fFin, DateTime horaI, int idTipo, int idCiudad)
        {

            string consulta = "INSERT INTO torneos([nombreTorneo],[lugar],[cupos],[fechaInicio],[fechaFin],[horaInicio],[idTipoTorneo],[idEstado])" +
                "VALUES ('" + nombre + "','" + lugar + "'," + cupos + ",'" + fIni + "','" + fFin + "','" + horaI + "'," + idTipo + "," + 1 + ")";
            SqlCommand comand = new SqlCommand(consulta, c.conecte());
            int cant = comand.ExecuteNonQuery();
            if (cant == 1)
            {
                int idTor = buscarUltimoTorneo();
                string con2 = "INSERT INTO ciudades_has_torneo([idCiudad],[idTorneo]) VALUES(" + idCiudad + "," + idTor + ")";
                SqlCommand comand2 = new SqlCommand(con2, c.conecte());
                comand2.ExecuteNonQuery();
                MessageBox.Show("Se Ha Registrado El Torneo Exitosamente");
                return true;
            }
            else
            {
                MessageBox.Show("Error Al Registrar El Torneo");
                return false;
            }
        }

        public int buscarUltimoTorneo()
        {

            string consulta = "SELECT * FROM torneos";
            SqlCommand comand = new SqlCommand(consulta, c.conecte());
            DataTable t = new DataTable();
            t.Load(comand.ExecuteReader());
            int coun = t.Rows.Count;
            int id = 0;
            for (int i = 1; i <= coun; i++)
            {
                if (i == coun)
                {
                    foreach (DataRow item in t.Rows)
                    {
                        id = Convert.ToInt32(item["idTorneo"].ToString());
                    }
                }

            }
            MessageBox.Show(id.ToString());
            return id;
        }

        public void cancelarTorneo(string nombreTorneo, int tor)
        {
            string q = "UPDATE torneos SET idEstado = 5 WHERE idTorneo =" + tor + " ";
            SqlCommand cmd = new SqlCommand(q, c.conecte());
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Se Ha Cancelado El Torneo " + nombreTorneo);
            }
            else
            {

                MessageBox.Show("Error Al Cancelar El Torneo");
            }
        }

        public DataTable buscarPorId(int id)
        {
            string consulta = "SELECT * FROM torneos WHERE idTorneo ="+id+" ";
            SqlCommand comand = new SqlCommand(consulta, c.conecte());
            DataTable t = new DataTable();
            t.Load(comand.ExecuteReader());
            return t;
        }

    }
}
