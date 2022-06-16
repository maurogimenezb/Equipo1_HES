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
            MostrarCons();

        }
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO FINAL - HES\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

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

        private void MostrarCons()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ConName from ConsultorioTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ConName");
            dt.Load(rdr);
            DCons.ValueMember = "ConName";
            DCons.DataSource = dt;
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
                DSpec.Text = AdmDocDGV.CurrentRow.Cells[3].Value.ToString();
                DDisp.Text = AdmDocDGV.CurrentRow.Cells[4].Value.ToString();
                DCons.Text = AdmDocDGV.CurrentRow.Cells[5].Value.ToString();
                DLastName.Text = AdmDocDGV.CurrentRow.Cells[6].Value.ToString();
                DUser.Text = AdmDocDGV.CurrentRow.Cells[7].Value.ToString();

            }

            catch
            {

            }
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            //string query = "update DoctorTbl set DocName= '"+DName.Text+ "', DocPass= '" + DPass.Text + "', DocSpec= '" + DSpec.Text + "', DocDisp= '" + DDisp.Text + "', DocCon= '" + DCons.Text + "', DocLastName= '" + DLastName.Text + "', DocUser= '" + DUser.Text + "' where DocId= " + DocId.Text + "";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("update DoctorTbl set DocCon= '" + DCons.Text + "',DocName=@DN,DocPass=@DP,DocSpec=@DS,DocDisp=@DD,DocLastName=@DLN,DocUser=@DU where DocId=@key", con);
            cmd.Parameters.AddWithValue("@DN", DName.Text);
            cmd.Parameters.AddWithValue("@DP", DPass.Text);
            cmd.Parameters.AddWithValue("@DS", DSpec.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DD", DDisp.Value.Date);
            //cmd.Parameters.AddWithValue("@DC", DCons.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DLN", DLastName.Text);
            cmd.Parameters.AddWithValue("@DU", DUser.Text);
            cmd.Parameters.AddWithValue("@key", DocId.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("update CitaTbl set FechaCon=@FC, DocSpec=@DSs where DocName=@DN", con);
            cmd1.Parameters.AddWithValue("@FC", DDisp.Value.Date);
            cmd1.Parameters.AddWithValue("@DN", DName.Text);
            cmd1.Parameters.AddWithValue("@DSs", DSpec.SelectedItem.ToString());
            cmd1.ExecuteNonQuery();


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

        private void AdmConBtn_Click(object sender, EventArgs e)
        {
            AdmConAdd FormAdd = new AdmConAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmPacDel FormPac = new AdmPacDel();
            FormPac.Show();
            this.Hide();
        }
    }
    }

