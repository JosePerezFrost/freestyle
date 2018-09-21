using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Sena.Logica;
namespace Edu.Sena.Presentacion
{
    public partial class InformacionTorneo : Form
    {
        int idTor = 0;
        Torneo torneo = new Torneo();
        public InformacionTorneo()
        {
            InitializeComponent();
        }

        public InformacionTorneo(int tor)
        {
            InitializeComponent();
            this.idTor = tor;
        }

        private void InformacionTorneo_Load(object sender, EventArgs e)
        {
            DataTable data = torneo.buscarPorId(idTor);
            DataRow row = data.Rows[0];
            lblNomTor.Text = row["nombreTorneo"].ToString();
            lblLugarTor.Text = row["lugar"].ToString();
            lblCuposTor.Text = row["cupos"].ToString();
            lblHoraTor.Text = row["horaInicio"].ToString();
            lblFechaITor.Text = row["fechaInicio"].ToString();
            lblFechaFTor.Text = row["fechaFin"].ToString();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            Participante p = new Participante();
            Boolean b = p.inscribirTorneo(idTor);
            if (b == true)
            {
                MessageBox.Show("Inscripcion Completada Correctamente");
            }
            else
            {
                MessageBox.Show("No Se Puede Registrar En Este Torneo");
            }
        }
    }
}
