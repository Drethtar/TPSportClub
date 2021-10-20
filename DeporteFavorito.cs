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
    public partial class DeporteFavorito : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public DeporteFavorito()
        {
            InitializeComponent();
        }
        private void DeporteFavorito_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseSportclub.accdb";
        }
        private void cbxCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDeportes.Items.Clear();
            cbxDeportes.Text = "";

            if (cbxCaracteristicas.Text == "De Contacto")
            {
                cbxDeportes.Items.Add("Esgrima");
                cbxDeportes.Items.Add("Football");
                cbxDeportes.Items.Add("Boxeo");
                cbxDeportes.Items.Add("Ninguno");
            }
            else
            {
                cbxDeportes.Items.Add("Natacion");
                cbxDeportes.Items.Add("Ajedrez");
                cbxDeportes.Items.Add("Atletismo");
                cbxDeportes.Items.Add("Ninguno");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "select * from Deportes where Nombre='"+ cbxDeportes.Text +"'";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();

            string IDDelDeporte = reader["ID"].ToString();

            connection.Close();
            connection.Open();

            command.CommandText = "update Usuario set DeporteFavorito='"+ IDDelDeporte +"' where Usuario='"+ IniciarSesion.ObtenerDatosUsuario.NombreDelUsuario +"'";
            command.ExecuteNonQuery();

            MessageBox.Show("Tu Deporte Favorito Fue Editado Con Exito!");

            connection.Close();

            this.Hide();
            new IniciarSesion().ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
