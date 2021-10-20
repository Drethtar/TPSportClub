using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TPDataBase
{
    public partial class SportClubHub : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public SportClubHub()
        {
            InitializeComponent();
        }
        private void SportClubHub_Load(object sender, EventArgs e)
        {
           try
            {
                this.WindowState = FormWindowState.Maximized;
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseSportclub.accdb";

                lblBienveni3.Text = "Hola! Bienvenid@ " + IniciarSesion.ObtenerDatosUsuario.NombreDelUsuario;

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM Deportes WHERE ID="+ IniciarSesion.ObtenerDatosUsuario.IDDeporteFavorito +"";
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                string CualEsSuDeporteFavorito = reader["Nombre"].ToString();

                

                lblDeporteFavorito.Text = "Deporte Favorito: "+ CualEsSuDeporteFavorito;
            }     
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }

        private void btnCambiarDeporteFavorito_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeporteFavorito().ShowDialog();
            this.Show();
        }
    }
}
