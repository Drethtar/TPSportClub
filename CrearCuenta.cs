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
    public partial class CrearCuenta : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseSportclub.accdb";
        }

        private void CrearCuentaphite()
        {
            try
            {

                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int count = 0;


                command.CommandText = "select * from Usuario where Usuario='" + txtUsuario.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1 || count > 1)
                {
                    MessageBox.Show("Ya existe una cuenta con los datos introducidos");
                    connection.Close();
                    return;

                }
                connection.Close();
                connection.Open();

                command.CommandText = "insert into Usuario (Usuario,Contra,DeporteFavorito) " + " values ('" + txtUsuario.Text + "','" + txtContra.Text + "','" + 13 + "')";
                command.ExecuteNonQuery();

                connection.Close();



                MessageBox.Show("Cuenta Creada Exitosamente");

                this.Hide();
                new SportClubHub().ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa, algo salo mal... " + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            CrearCuentaphite();
        }

        private void lblInicarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CrearCuentaphite();
            }
        }
    }
}
