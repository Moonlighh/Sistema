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
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=tcp:basedatossrver.database.windows.net,1433;Initial Catalog=ServicioTecnico;Persist Security Info=False;User ID=joseph;Password=Joandle123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void llenar_tabla()
        {

            string consulta = "select * from Vendedor";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dgvVendedor.DataSource = dt;
        }


        public void limpiarEntradas()
        {
            txtidVendedor.Text = "";
            txtNombre_vendedor.Text = "";
            txtDireccion_vendedor.Text = "";
            txtTelefono_vendedor.Text = "";
            txtEmail_vendedor.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into Vendedor values('" + txtidVendedor.Text + "','" + txtNombre_vendedor.Text + "','" + txtDireccion_vendedor.Text + "','" + txtTelefono_vendedor.Text + "','" + txtEmail_vendedor.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();
            limpiarEntradas();
            con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
      
            string buscar = "select * from Vendedor where idVendedor='" + txtidVendedor.Text + "'";
            SqlCommand comando = new SqlCommand(buscar, con);
            SqlDataReader dr = comando.ExecuteReader();


            while (dr.Read())
            {
                txtNombre_vendedor.Text = dr.GetString(1);
                txtDireccion_vendedor.Text = dr.GetString(2);
                txtTelefono_vendedor.Text = dr.GetValue(3).ToString();
                txtEmail_vendedor.Text = dr.GetString(4);

            }

            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "update Vendedor set idVendedor='" + txtidVendedor.Text + "',Nombre_vendedor='" + txtNombre_vendedor.Text + "',Direccion_vendedor='" + txtDireccion_vendedor.Text + "',Telefono_vendedor=" + txtTelefono_vendedor.Text + ",Email_vendedor='" + txtEmail_vendedor.Text + "' where idVendedor='" + txtidVendedor.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado");
            llenar_tabla();
            con.Close();
            txtidVendedor.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from Vendedor where idVendedor='" + txtidVendedor.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenar_tabla();

            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarEntradas();
           
        }

        private void Vendedor_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void dgvVendedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidVendedor.Text = dgvVendedor.SelectedCells[0].Value.ToString();
            txtNombre_vendedor.Text = dgvVendedor.SelectedCells[1].Value.ToString();
            txtDireccion_vendedor.Text = dgvVendedor.SelectedCells[2].Value.ToString();
            txtTelefono_vendedor.Text = dgvVendedor.SelectedCells[3].Value.ToString();
            txtEmail_vendedor.Text = dgvVendedor.SelectedCells[4].Value.ToString();
            txtidVendedor.Enabled = false;
        }
    }

}
