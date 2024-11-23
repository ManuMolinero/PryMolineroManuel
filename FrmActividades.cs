using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMolineroManuel
{
    public partial class FrmActividades : Form
    {
        private OleDbConnection connection;
        public FrmActividades()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Molinero.mdb";
            connection = new OleDbConnection(connectionString);
        }

        private void FrmActividades_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarActividades_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            CargarActividades(fechaInicio, fechaFin);
        }
    }
}
