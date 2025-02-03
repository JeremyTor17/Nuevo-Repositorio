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

namespace Reservas
{
    public partial class Reservas : Form
    {
        static string consql = "server= localhost ; database= proyectofinal ; integrated security= true";

        SqlConnection conexion = new SqlConnection(consql);

        public Reservas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            conexion.Open();
        }

        public void Mostrar()
        {
            string query = "Select * From Reservas";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            BdD.DataSource = tabla;
        }

        private void AgSal_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO Reservas (ID_Sala, Cliente, FechaInicio, FechaFin, Motivo)" +
                " VALUES ('"+ ID_Sala.Text + "', '"+ Cliente.Text +"', '"+ Fecha_Inicio.Text +"', '"+ Fecha_Fin.Text +"', '"+ Motivo.Text +"');";
            SqlCommand comando = new SqlCommand(agregar, conexion);
            comando.ExecuteNonQuery();

            ID_Sala.Text = "";
            Cliente.Text = "";
            Fecha_Inicio.Text = "";
            Fecha_Fin.Text = "";
            Motivo.Text = "";

            this.Mostrar();
        }

        private void BoSal_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BdD.CurrentRow.Cells["id"].Value);

            string borrar = "delete from Reservas Where ID = '" + id + "';";
            SqlCommand comando = new SqlCommand(borrar, conexion);
            comando.ExecuteNonQuery();

            this.Mostrar();
        }

        private void MoSal_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BdD.CurrentRow.Cells["id"].Value);

            string modificar = "Update Reservas set ID_Sala = '"+ ID_Sala.Text + "', Cliente = '"+ Cliente.Text + "', FechaInicio = '"+ Fecha_Inicio.Text + "', FechaFin = '"+ Fecha_Fin.Text + "', Motivo = '"+ Motivo.Text + "' Where ID = '"+ id + "';";
            SqlCommand comando = new SqlCommand(modificar, conexion);
            comando.ExecuteNonQuery();

            ID_Sala.Text = "";
            Cliente.Text = "";
            Fecha_Inicio.Text = "";
            Fecha_Fin.Text = "";
            Motivo.Text = "";

            this.Mostrar();
        }

        private void BdD_SelectionChanged(object sender, EventArgs e)
        {
            ID_Sala.Text = Convert.ToString(BdD.CurrentRow.Cells["id_sala"].Value);
            Cliente.Text = Convert.ToString(BdD.CurrentRow.Cells["cliente"].Value); ;
            Fecha_Inicio.Text = Convert.ToString(BdD.CurrentRow.Cells["fechainicio"].Value); ;
            Fecha_Fin.Text = Convert.ToString(BdD.CurrentRow.Cells["fechafin"].Value); ;
            Motivo.Text = Convert.ToString(BdD.CurrentRow.Cells["motivo"].Value); ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
