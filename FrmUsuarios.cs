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
    public partial class FrmUsuarios : Form
    {
        private OleDbConnection connection;
        public FrmUsuarios()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Molinero.mdb";
            connection = new OleDbConnection(connectionString);
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT DISTINCT Categoria FROM Usuarios", connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode node = new TreeNode(reader["Categoria"].ToString());
                    treeViewUsuarios.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void treeViewUsuarios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Cargar usuarios según la categoría seleccionada
            CargarUsuarios(e.Node.Text);
        }
        private void CargarUsuarios(string categoria)
        {
            treeViewUsuarios.Nodes.Clear(); // Limpiar el TreeView antes de cargar
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand($"SELECT Nombre FROM Usuarios WHERE Categoria = '{categoria}'", connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode node = new TreeNode(reader["Nombre"].ToString());
                    treeViewUsuarios.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
