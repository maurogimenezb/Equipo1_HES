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
    public partial class AdmConEdit : Form
    {
        public AdmConEdit()
        {
            InitializeComponent();
            MostrarCons();
        }
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Hospital 2.0\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        private void MostrarCons()
        {
            con.Open();
            string Query = "Select * from ConsultorioTbl"; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            AdmDocDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void AdmDocDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DocId.Text = AdmDocDGV.CurrentRow.Cells[0].Value.ToString();
                DName.Text = AdmDocDGV.CurrentRow.Cells[1].Value.ToString();

            }

            catch
            {

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update ConsultorioTbl set ConName= '" + DName.Text + "' where ConId= " + DocId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha modificado consultorio");
            con.Close();
            MostrarCons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmDocAdd FormAdmDocAdd = new AdmDocAdd();
            FormAdmDocAdd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmConAdd FormAdd = new AdmConAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            AdmConAdd FormAdd = new AdmConAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            AdmConDel FormDel = new AdmConDel();
            FormDel.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            AdmPacDel FormPac = new AdmPacDel();
            FormPac.Show();
            this.Hide();
        }
    }
}
