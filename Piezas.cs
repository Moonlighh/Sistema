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
    public partial class Piezas : Form
    {
        public Piezas()
        {
            InitializeComponent();
        }
        static string servidor = "localhost";
        static string bd = "ServicioTecnico";
        static string usuario = "Mantenimiento";
        static string contraseña = "1234";
        static string puerto = "1433";


        // string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";
        SqlConnection con = new SqlConnection("Data Source = " + servidor + ", " + puerto + ";" + "user id = " + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog = " + bd + ";" + "Persist Security Info=true");
        public void llenar_tabla()
        {

            string consulta = "select * from Piezas";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dgvPiezas.DataSource = dt;
        }
        private void Piezas_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into Piezas values(" + txtcod.Text + ",'" + txtcop.Text + "','" + txtnombre.Text + "','" + txtCosto.Text + "','" + txtStock.Text + "','" + txtfabri.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();
           // +txtcod.Text + ",'" +//
            con.Close();
        }
    }
}
