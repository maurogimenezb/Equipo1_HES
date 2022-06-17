using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Se agrega para la conexion a la BD

namespace Equipo1_HES
{
    public partial class DocDispAdd : Form
    {
        public DocDispAdd()
        {
            InitializeComponent();
        }

        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Hospital 2.0\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        private void ActDisp()
        {
            con.Open();
            SqlCommand leer = new SqlCommand("Select * from DoctorTbl where DocId='" + DocId.Text + "'",  con);
            SqlDataReader datos = leer.ExecuteReader();

            if (datos.Read() == true)
            {

                DocLogged.disp = datos["DocDisp"].ToString();


            }
            datos.Close();
            con.Close();

            RegLbl.Text = DocLogged.disp;

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DispDat.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update DoctorTbl set DocDisp=@DD where DocId=@key", con);
                    cmd.Parameters.AddWithValue("@DD", DispDat.Value.Date);
                    cmd.Parameters.AddWithValue("@key", DocId.Text);
                    cmd.ExecuteNonQuery();

                   // SqlCommand cmd1 = new SqlCommand("update CitaTbl set FechaCon=@FC where DocName=@DN", con);
                   // cmd1.Parameters.AddWithValue("@FC", DispDat.Value.Date);
                    //cmd1.Parameters.AddWithValue("@DN", DName.Text);
                    //cmd1.ExecuteNonQuery();
                    MessageBox.Show("Disponibilidad Agregado");

                    con.Close();
                    ActDisp();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                /*con.Open();
                string query = "update DoctorTbl set DocDisp= '" + DispDat.Value.Date + "' where DocId=" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el Consultorio");
                con.Close();*/
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void DocDispAdd_Load(object sender, EventArgs e)
        {
            DocId.Text = DocLogged.id;
            RegLbl.Text = DocLogged.disp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            DocProf DocProf = new DocProf();
            DocProf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            CunsultasDoc Consultas = new CunsultasDoc();
            Consultas.Show();
            this.Hide();
        }
    }
}
