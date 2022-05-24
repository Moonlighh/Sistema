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


namespace Sistema
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=DESKTOP-RSFCT1G\\SQLEXPRESS;Initial Catalog=ServicioTecnico; Integrated Security=True";
        public void llenar_tabla()
        {
            SqlConnection con = new SqlConnection(conexion);
            string consulta = "select * from Citas";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            String consulta = "insert into Citas values('" + txtNumCita.Text + "', '" + txtHoraCita.Text + "', '" + txtFechaCita.Text + "');";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            llenar_tabla();
            MessageBox.Show("Registro Agregado");
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            string consulta = "delete from citas where numeroDeCita='" + txtNumCita.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            llenar_tabla();
            MessageBox.Show("Registro Eliminado");


            con.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            string consulta = "update Citas set numeroDeCita = '" + txtNumCita.Text + "', hora = '" + txtHoraCita.Text + "', fecha = '" + txtFechaCita.Text + "';";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            llenar_tabla();
            MessageBox.Show("Registro Modificado");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumCita_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
