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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        static string servidor = "localhost";
        static string bd = "ServicioTecnico";
        static string usuario = "sa";
        static string contraseña = "edson123147";
        static string puerto = "1433";


        // string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";
        SqlConnection con = new SqlConnection("Data Source = " + servidor + ", " + puerto + ";" + "user id = " + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog = " + bd + ";" + "Persist Security Info=true");
        public void llenar_tabla()
        {

            string consulta = "select * from Cliente";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }
    }
}
