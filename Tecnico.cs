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
    public partial class Tecnico : Form
    {
        public Tecnico()
        {
            InitializeComponent();
        }
      
        static string servidor = "localhost";
        static string bd = "ServicioTecnico";
        static string usuario = "sa";
        static string contraseña = "edson123147";
        static string puerto = "1433";



        SqlConnection con = new SqlConnection("Data Source = " + servidor + ", " + puerto + ";" + "user id = " + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog = " + bd + ";" + "Persist Security Info=true");
        private void Tecnico_Load(object sender, EventArgs e)
        {

        }
        public void llenar_tabla()
        {

            string consulta = "select * from Tecnico";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            con.Open();
            string consulta = "insert into tecnico values('" + txtIdTecnico.Text + "','" + txtNombreTecnico.Text + "','" + txtDireccionTecnico.Text + "','" + txtTelefonoTecnico.Text + "','" + txtEmailTecnico.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();

            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
