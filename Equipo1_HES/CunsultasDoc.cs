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
    public partial class CunsultasDoc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Hospital 2.0\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        public CunsultasDoc()
        {
            InitializeComponent();
            MostrarConsultasDoc();
        }


        public void MostrarConsultasDoc()
        {
            con.Open();
            string Query = "Select * from CitaTbl where FechaCon='" + DocLogged.disp + "' and DocName='" + DocLogged.name + "'"; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            ConsultasDoc.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ConsultasDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocDispAdd FormDocDispAdd = new DocDispAdd();
            FormDocDispAdd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            DocProf DocProf = new DocProf();
            DocProf.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
