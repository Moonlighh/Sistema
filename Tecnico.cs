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
//
// Creado: Edson Antonio Contreras Perez 
//
namespace Sistema
{
    public partial class Tecnico : Form
    {
        public Tecnico()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Server=tcp:basedatossrver.database.windows.net,1433;Initial Catalog=ServicioTecnico;Persist Security Info=False;User ID=joseph;Password=Joandle123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");


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
        public void habilitar()
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        public void desHabilitar()
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            btnBuscar.Enabled = true;

        }
        public void limpiarEntradas()
        {
            txtIdTecnico.Text = "";
            txtNombreTecnico.Text = "";
            txtDireccionTecnico.Text = "";
            txtEmailTecnico.Text = "";
            txtTelefonoTecnico.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "insert into tecnico values('" + txtIdTecnico.Text + "','" + txtNombreTecnico.Text + "','" + txtDireccionTecnico.Text + "','" + txtTelefonoTecnico.Text + "','" + txtEmailTecnico.Text + "')";
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
            habilitar();
            string buscar = "select * from Tecnico where idTecnico='" + txtIdTecnico.Text + "'";
            SqlCommand comando = new SqlCommand(buscar, con);
            SqlDataReader dr = comando.ExecuteReader();


            while (dr.Read())
            {
                txtNombreTecnico.Text = dr.GetString(1);
                txtDireccionTecnico.Text = dr.GetString(2);
                txtTelefonoTecnico.Text = dr.GetValue(3).ToString();
                txtEmailTecnico.Text = dr.GetString(4);

            }

            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from Tecnico where idTecnico='" + txtIdTecnico.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenar_tabla();

            con.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "update Tecnico set idTecnico='" + txtIdTecnico.Text + "',Nombre_tecnico='" + txtNombreTecnico.Text + "',Direccion_tecnico='" + txtDireccionTecnico.Text + "',Telefono_tecnico=" + txtTelefonoTecnico.Text + ",Email_tecnico='" + txtEmailTecnico.Text + "' where idTecnico='" + txtIdTecnico.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado");
            llenar_tabla();
            con.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
            desHabilitar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
