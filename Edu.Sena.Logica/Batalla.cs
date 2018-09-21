using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Sena.Datos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Edu.Sena.Logica
{
    public class Batalla
    {
        private int idBatalla;
        private DateTime fechaBatalla;

        private List<Participante> participantes;
        private Torneo torneo;
        private FaseTorneo fase;

        Conexion c = new Conexion();

        public int IdBatalla { get => idBatalla; set => idBatalla = value; }
        public DateTime FechaBatalla { get => fechaBatalla; set => fechaBatalla = value; }
        internal List<Participante> Participantes { get => participantes; set => participantes = value; }
        internal FaseTorneo Fase { get => fase; set => fase = value; }
        internal Torneo Torneo { get => torneo; set => torneo = value; }

        public Batalla()
        {
        }

        public void registrarBatalla(int idTorneo, int idFase, DateTime fecha, long par1 , long par2)
        {
            string q = "INSERT INTO [dbo].[batallas]([idTorneo],[idFaseTorneo],[fechaBatalla])"+
                        "VALUES("+idTorneo+","+idFase+",'"+fecha+"')";
            SqlCommand cmd = new SqlCommand(q, c.conecte());
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                int idBatalla = buscarUltimaBatalla();
                long u = 0;
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        u = par1;
                    }
                    else
                    {
                        u = par2;
                    }

                    string p = "INSERT INTO [dbo].[batallas_has_participantes]([idBatalla],[cedulaParticipante])" +
                    "VALUES(" + idBatalla + "," + u + ")";
                    cmd = new SqlCommand(p, c.conecte());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Se Ha Agregado Una Nueva Batalla");

            }
            else
            {
                MessageBox.Show("No Se Ha Podido Agregar La Batalla");
            }
        }

        public int buscarUltimaBatalla()
        {
            string query = "SELECT * FROM batallas";
            SqlCommand cm = new SqlCommand(query,c.conecte());
            DataTable d = new DataTable();
            d.Load(cm.ExecuteReader());
            int id = 0, coun = d.Rows.Count;
            for (int i = 1; i <= coun; i++)
            {
                if (i == coun)
                {
                    foreach (DataRow item in d.Rows)
                    {
                        id = Convert.ToInt32(item["idBatalla"].ToString());
                    }
                }
            }
            return id;

        }

        
    }
}
