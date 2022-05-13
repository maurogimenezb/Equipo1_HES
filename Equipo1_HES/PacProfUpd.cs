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
    public partial class PacProfUpd : Form
    {
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO HES\Base de Datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        public PacProfUpd()
        {
            InitializeComponent();
        }
        
        private void ActPac()
        {
            con.Open();
            SqlCommand leer = new SqlCommand("Select * from PacienteTbl where PacId='" + TxtId.Text + "'", con);
            SqlDataReader datos = leer.ExecuteReader();

            if (datos.Read() == true)
            {

                PacLogged.name = datos["PacName"].ToString();
                PacLogged.pass = datos["PacPass"].ToString();
                PacLogged.sexo = datos["PacGen"].ToString();
                PacLogged.phone = datos["PacPhone"].ToString();
                PacLogged.nac = datos["PacDOB"].ToString();
                PacLogged.id = datos["PacId"].ToString();


            }
            datos.Close();
            con.Close();
        } 

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void HomePac_Load(object sender, EventArgs e)
        {
            TxtName.Text = PacLogged.name;
            TxtPass.Text = PacLogged.pass;
            ComBoxGen.Text = PacLogged.sexo;
            TxtPhone.Text = PacLogged.phone;
            DataTimeDOB.Text = PacLogged.nac;
            TxtId.Text = PacLogged.id;

        }

        private void AdmHomeBtn_Click(object sender, EventArgs e)
        {
            HomePac FormHomePac = new HomePac();
            FormHomePac.Show();
            this.Hide();
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update PacienteTbl set PacName= '" + TxtName.Text + "', PacPass= '" + TxtPass.Text + "' where PacId= " + TxtId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha modificado paciente");
            con.Close();
            ActPac();
        }

        private void AtrBtn_Click(object sender, EventArgs e)
        {
            PacProf FormPacProf = new PacProf();
            FormPacProf.Show();
            this.Hide();
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            PacProfUpd FormPacProfUpd = new PacProfUpd();
            FormPacProfUpd.Show();
            this.Hide();
        }
    }
}
