using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMolineroManuel
{
    public partial class frmInicio : Form
    {
        private OleDbConnection connection;
        public frmInicio()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Molinero.mdb";
            connection = new OleDbConnection(connectionString);
            VerificarConexion();
        }
    private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActividades actividades = new FrmActividades();
            actividades.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            reportes.Show();
        }

        private void VerificarConexion()
        {
            try
            {
                connection.Open();
                lblEstadoConexion.Text = "Conectado";
            }
            catch
            {
                lblEstadoConexion.Text = "Desconectado";
            }
            finally
            {
                connection.Close();
            }
        }
        private void lblChequeoConexion_Click(object sender, EventArgs e)
        {

        }
    }
}
