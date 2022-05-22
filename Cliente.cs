using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=tcp:basedatossrver.database.windows.net,1433;Initial Catalog=ServicioTecnico;Persist Security Info=False;User ID=joseph;Password=Joandle123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        public void llenar_tabla()
        {

            string consulta = "select * from Cliente";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void limpiarEntradas()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }


        private void Cliente_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_tabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into Cliente values(" + txtId.Text + ",'" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtCorreo.Text + "','" + txtTelefono.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();

            con.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "update cliente set IdCliente=" + txtId.Text + ",Nombre_cliente='" + txtNombre.Text + "',Direccion_cliente='" + txtDireccion.Text + "',Email_cliente='" + txtCorreo.Text + "',Telefono_cliente='" + txtTelefono.Text + "' where IdCliente=" + txtId.Text + "";
            SqlCommand comando = new SqlCommand(consulta, con);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado");
            llenar_tabla();
            con.Close();
            txtId.Enabled = true;

            limpiarEntradas();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from Cliente where IdCliente=" + txtId.Text + "";
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
            txtDireccion.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtCorreo.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[4].Value.ToString();

            txtId.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
