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

        SqlConnection con = new SqlConnection("Server=tcp:basedatossrver.database.windows.net,1433;Initial Catalog=ServicioTecnico;Persist Security Info=False;User ID=joseph;Password=Joandle123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        public void llenar_tabla()
        {

            string consulta = "select * from Producto";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void limpiarEntradas()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
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
            //hola
            llenar_tabla();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_tabla();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into Producto values(" + txtId.Text + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "','" + txtStock.Text + "','" + txtPrecio.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();

            con.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into Producto values(" + txtId.Text + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "','" + txtStock.Text + "','" + txtPrecio.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();

            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from Producto where IdProducto=" + txtId.Text + "";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenar_tabla();

            con.Close();

            limpiarEntradas();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtStock.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtPrecio.Text = dataGridView1.SelectedCells[4].Value.ToString();

            txtId.Enabled = false;
        }
    }
}
