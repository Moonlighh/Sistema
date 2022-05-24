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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=tcp:basedatossrver.database.windows.net,1433;Initial Catalog=ServicioTecnico;Persist Security Info=False;User ID=joseph;Password=Joandle123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        public void llenar_tabla()
        {

            string consulta = "select * from Almacen";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        public void limpiarEntradas()
        {
            txtIdDireccion.Text = "";
            txtDirección.Text = "";
            txtDistrito.Text = "";
            txtProvincia.Text = "";
            txtCod_postal.Text = "";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into Almacen values('" + txtIdDireccion.Text + "','" + txtDirección.Text + "','" + txtDistrito.Text + "','" + txtProvincia.Text + "','" + txtCod_postal.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            llenar_tabla();
            limpiarEntradas();
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string buscar = "select * from Almacen where IdDireccion='" + txtIdDireccion.Text + "'";
            SqlCommand comando = new SqlCommand(buscar, con);
            SqlDataReader dr = comando.ExecuteReader();


            while (dr.Read())
            {
                txtDirección.Text = dr.GetString(1);
                txtDistrito.Text = dr.GetString(2);
                txtProvincia.Text = dr.GetValue(3).ToString();
                txtCod_postal.Text = dr.GetString(4);

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "update Almacen set IdDireccion='" + txtIdDireccion.Text + "',Dirección='" + txtDirección.Text + "',Distrito='" + txtDistrito.Text + "',Provincia=" + txtProvincia.Text + ",Codigo postal='" + txtCod_postal.Text + "' where IdDireccion='" + txtIdDireccion.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado");
            llenar_tabla();
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from Almacen where IdDireccion='" + txtIdDireccion.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenar_tabla();

            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }
    }
}
