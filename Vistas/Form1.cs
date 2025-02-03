using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class Form1 : Form
    {
        
        static string consql = "server= localhost ; database= proyectofinal ; integrated security= true";

        SqlConnection conexion = new SqlConnection(consql);

        public Form1()
        {
            InitializeComponent();
        }

        private void AgSal_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO Salas (Nombre, Capacidad, Descripción)" +
                " VALUES ('" + Nombre.Text + "', '" + Capacidad.Text + "', '" + Descripcion.Text + "');";
            SqlCommand comando = new SqlCommand(agregar, conexion);
            comando.ExecuteNonQuery();

            Nombre.Text = "";
            Capacidad.Text = "";
            Descripcion.Text = "";

            this.Mostrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            conexion.Open();
        }

        public void Mostrar()
        {
            string query = "Select * From Salas";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            BdD.DataSource = tabla;
        }

        private void BoSal_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BdD.CurrentRow.Cells["id"].Value);

            string borrar = "delete from Salas Where ID = '" + id + "';";
            SqlCommand comando = new SqlCommand(borrar, conexion);
            comando.ExecuteNonQuery();

            this.Mostrar();
        }

        private void MoSal_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BdD.CurrentRow.Cells["id"].Value);

            string modificar = "Update Salas set Nombre = '" + Nombre.Text + "', Capacidad = '" + Capacidad.Text + "', Descripción = '" + Descripcion.Text + "' Where ID = '" + id + "';";
            SqlCommand comando = new SqlCommand(modificar, conexion);
            comando.ExecuteNonQuery();

            Nombre.Text = "";
            Capacidad.Text = "";
            Descripcion.Text = "";

            this.Mostrar();
        }
    }
}
