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

        string nombrecompleto = "";
        string registro = "";

        public string generarRegistro(string nombre)
        {
            string[] nombreseparado = nombre.Split(' ').ToArray();
            registro = "";
            for (int i = 0; i < nombreseparado.Length; i++)
            {
                registro += nombreseparado[i].Substring(0, 1).ToUpper();
            }
            registro = registro + " - ";
            Random codigo = new Random();
            int valor = codigo.Next(1, 2000);
            registro += valor.ToString();
            return registro;
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
        
            string consulta = "insert into Piezas values(" + txtxcod.Text + ",'" + txtnombre.Text + "','" + txtCosto.Text + "','" + txtStock.Text + "','" + txtfabri.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);           
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();
         
            con.Close();
        }

        private void dgvPiezas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtdni.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtnombre.Text = dgvPiezas.SelectedCells[1].Value.ToString();
            txtCosto.Text = dgvPiezas.SelectedCells[2].Value.ToString();
            txtStock.Text = dgvPiezas.SelectedCells[3].Value.ToString();
            txtfabri.Text = dgvPiezas.SelectedCells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "update cliente set DNI=" + txtxcod.Text + ",nombre='" + txtnombre.Text + "',sexo='" + txtCosto.Text + "',edad='" + txtStock.Text + "',telefono='" + txtfabri.Text + "' where DNI=" + txtxcod.Text + "";
            SqlCommand comando = new SqlCommand(consulta, con);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado");
            llenar_tabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from cliente where DNI=" + txtxcod.Text + "";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenar_tabla();

            con.Close();
        }
    }
}
