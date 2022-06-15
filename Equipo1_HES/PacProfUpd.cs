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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Hospital 2.0\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

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
                PacLogged.lastname = datos["PacLastName"].ToString();
                PacLogged.user = datos["PacUser"].ToString();
                PacLogged.pass = datos["PacPass"].ToString();
                PacLogged.gen = datos["PacGen"].ToString();
                PacLogged.phone = datos["PacPhone"].ToString();
                PacLogged.dob = datos["PacDOB"].ToString();
                PacLogged.id = datos["PacId"].ToString();
                PacLogged.ci = datos["PacCI"].ToString();


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
            TxtLastName.Text = PacLogged.lastname;
            TxtUser.Text = PacLogged.user;
            TxtPass.Text = PacLogged.pass;
            ComBoxGen.Text = PacLogged.gen;
            TxtPhone.Text = PacLogged.phone;
            DataTimeDOB.Text = PacLogged.dob;
            TxtId.Text = PacLogged.id;
            TxtCI.Text = PacLogged.ci;


        }

        private void AdmHomeBtn_Click(object sender, EventArgs e)
        {
            HomePac FormHomePac = new HomePac();
            FormHomePac.Show();
            this.Hide();
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update PacienteTbl set PacName=@PN,PacPass=@PP,PacGen=@PG,PacPhone=@PPh,PacDOB=@PD,PacLastName=@PLN,PacUser=@PU,PacCI=@PCI where PacId=@key", con);
                cmd.Parameters.AddWithValue("@PN", TxtName.Text);
                cmd.Parameters.AddWithValue("@PP", TxtPass.Text);
                cmd.Parameters.AddWithValue("@PG", ComBoxGen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PPh", TxtPhone.Text);
                cmd.Parameters.AddWithValue("@PD", DataTimeDOB.Value.Date);
                cmd.Parameters.AddWithValue("@PLN", TxtLastName.Text);
                cmd.Parameters.AddWithValue("@PU", TxtUser.Text);
                cmd.Parameters.AddWithValue("@PCI", TxtCI.Text);
                cmd.Parameters.AddWithValue("@key", TxtId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Perfil Modificado");

                con.Close();
                ActPac();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdmDocBtn_Click_1(object sender, EventArgs e)
        {
            PacProf FormPacProf = new PacProf();
            FormPacProf.Show();
            this.Hide();
        }

        private void CitaBtn_Click(object sender, EventArgs e)
        {
            PacCita FormPacCita = new PacCita();
            FormPacCita.Show();
            this.Hide();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            PacCitaElim FormPacCitaElim = new PacCitaElim();
            FormPacCitaElim.Show();
            this.Hide();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            PacCitaEdit ModicicarCita = new PacCitaEdit();
            ModicicarCita.Show();
            this.Hide();
        }
    }
}
