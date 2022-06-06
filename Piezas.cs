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
        
        
        //PALMA CRUZ JOSEPH
        
        SqlConnection con = new SqlConnection("Server=tcp:basedatossrver.database.windows.net,1433;Initial Catalog=ServicioTecnico;Persist Security Info=False;User ID=joseph;Password=Joandle123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");



        public void llenar_tabla()
        {

            string consulta = "select * from Piezas";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dgvPiezas.DataSource = dt;
        }
        public void limpiarEntradas()
        {
            txtxcod.Text = "";
            txtnombre.Text = "";
            txtCosto.Text = "";
            txtStock.Text = "";
            txtfabri.Text = "";
            txtxcod.Enabled = true;
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

            limpiarEntradas();
        }

        private void dgvPiezas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           txtxcod.Text = dgvPiezas.SelectedCells[0].Value.ToString();
            txtnombre.Text = dgvPiezas.SelectedCells[1].Value.ToString();
            txtCosto.Text = dgvPiezas.SelectedCells[2].Value.ToString();
            txtStock.Text = dgvPiezas.SelectedCells[3].Value.ToString();
            txtfabri.Text = dgvPiezas.SelectedCells[4].Value.ToString();
            txtxcod.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "update Piezas set IdPieza=" + txtxcod.Text + ",nombre='" + txtnombre.Text + "',coste='" + txtCosto.Text + "',stok='" + txtStock.Text + "',fabrica='" + txtfabri.Text + "' where IdPieza=" + txtxcod.Text + "";
            SqlCommand comando = new SqlCommand(consulta, con);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado");
            llenar_tabla();
            txtxcod.Enabled = true;
            con.Close();
            limpiarEntradas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from Piezas where IdPieza=" + txtxcod.Text + "";
            SqlCommand comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenar_tabla();

            con.Close();
            limpiarEntradas();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
