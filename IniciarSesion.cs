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
    public partial class IniciarSesion : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        public static class ObtenerDatosUsuario
        {

            public static int IDdelUsuario = 0;
            public static string NombreDelUsuario = "";
            public static int IDDeporteFavorito = 0;
        }
        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseSportclub.accdb";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "select * from Usuario where Usuario='" + txtUsuario.Text + "' and Contra='" + txtContra.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count += 1;
                }

                connection.Close();

                if (count == 1)
                {
                    connection.Open();
                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;

                    command2.CommandText = "select * from Usuario where Usuario='" + txtUsuario.Text + "' and Contra='" + txtContra.Text + "'";

                    OleDbDataReader reader2 = command2.ExecuteReader();
                    reader2.Read();

                    string IDObtenidoDelUsuario = reader2["ID"].ToString();
                    string DeporteFav = reader2["DeporteFavorito"].ToString();
                    IniciarSesion.ObtenerDatosUsuario.IDdelUsuario = Convert.ToInt32(IDObtenidoDelUsuario);
                    IniciarSesion.ObtenerDatosUsuario.NombreDelUsuario = txtUsuario.Text;
                    IniciarSesion.ObtenerDatosUsuario.IDDeporteFavorito = Convert.ToInt32(DeporteFav);

                    this.Hide();
                    new SportClubHub().ShowDialog();
                    this.Show();
                }
                else if (count < 1)
                {
                    MessageBox.Show("Los datos introducidos son incorrectos");
                    return;

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa algo salio mal... " + ex);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearCuenta().ShowDialog();
            this.Show();
        }
    }
}
