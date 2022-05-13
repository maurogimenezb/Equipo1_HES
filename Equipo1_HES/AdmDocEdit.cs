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
    public partial class AdmDocEdit : Form
    {
        public AdmDocEdit()
        {
            InitializeComponent();
            MostrarDoc();
        }
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO HES\Base de Datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        private void MostrarDoc()
        {
            con.Open();
            string Query = "Select * from DoctorTbl"; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            AdmDocDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AdmDocEdit_Load(object sender, EventArgs e)
        {
        }
        private void AdmDocDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DocId.Text = AdmDocDGV.CurrentRow.Cells[0].Value.ToString();
                DName.Text = AdmDocDGV.CurrentRow.Cells[1].Value.ToString();
                DPass.Text = AdmDocDGV.CurrentRow.Cells[2].Value.ToString();
                DPhone.Text = AdmDocDGV.CurrentRow.Cells[3].Value.ToString();
            }

            catch
            {

            }
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update DoctorTbl set DocName= '"+DName.Text+ "', DocPass= '" + DPass.Text + "' where DocId= " + DocId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha modificado doctor");
            con.Close();
            MostrarDoc();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AdmDocAdd FormAdd = new AdmDocAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            AdmDocDel FormDel = new AdmDocDel();
            FormDel.Show();
            this.Hide();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            AdmDocEdit FormEdit = new AdmDocEdit();
            FormEdit.Show();
            this.Hide();
        }

        private void AdmHomeBtn_Click(object sender, EventArgs e)
        {
            HomeAdm FormHomeAdm = new HomeAdm();
            FormHomeAdm.Show();
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
    }
    }

