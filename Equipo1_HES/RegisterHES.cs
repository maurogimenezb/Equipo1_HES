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
    public partial class RegisterHES : Form
    {
        public RegisterHES()
        {
            InitializeComponent();
        }

        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Hospital 2.0\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || PLastName.Text == "" || PUser.Text == "" || PPass.Text == "" || PGen.Text == "" || PPhone.Text == "" || PDOB.Text == "" || PCI.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PacienteTbl(PacName,PacPass,PacGen,PacPhone,PacDOB,PacLastName,PacUser,PacCI)values(@PN,@PP,@PG,@PPh,@PD,@LN,@PU,@PCI)", con);
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@PP", PPass.Text);
                    cmd.Parameters.AddWithValue("@PG", PGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PPh", PPhone.Text);
                    cmd.Parameters.AddWithValue("@PD", PDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@LN", PLastName.Text);
                    cmd.Parameters.AddWithValue("@PU", PUser.Text);
                    cmd.Parameters.AddWithValue("@PCI", PCI.Text);

                    cmd.ExecuteNonQuery();
                    LoginHES login = new LoginHES();
                    login.Show();
                    this.Hide();
                    //MessageBox.Show("Doctor Agregado");

                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            LoginHES atras = new LoginHES();
            atras.Show();
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
    }
}
