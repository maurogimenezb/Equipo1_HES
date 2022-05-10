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
    public partial class AdmDoc : Form
    {
        public AdmDoc()
        {
            InitializeComponent();
            MostrarDoc();
        }
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\repos\Equipo1_HES\Equipo1_HES\Base de Datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");


        // Para mostrar los Doctores en el Data
        private void MostrarDoc ()
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
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || DPass.Text == "" || DPhone.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            } else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DocPass,DocPhone)values(@DN,@DP,@DPh)", con);
                    cmd.Parameters.AddWithValue("@DN",DName.Text);
                    cmd.Parameters.AddWithValue("@DP", DPass.Text);
                    cmd.Parameters.AddWithValue("@DPh", DPhone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Agregado");

                    con.Close();
                    MostrarDoc();

                } catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void AdmDocDGV_Mostrar (object sender, DataGridViewCellEventArgs e)
        {
            DName.Text = AdmDocDGV.SelectedRows[0].Cells[1].Value.ToString();
            DPass.Text = AdmDocDGV.SelectedRows[0].Cells[2].Value.ToString();
            DPhone.Text = AdmDocDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (DName.Text == "")
            {
                Key = 0;
            } else
            {
                Key = Convert.ToInt32(DName.Text = AdmDocDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES cerrar = new LoginHES();
            cerrar.Show();
            this.Hide();
        }

        private void AdmHomeBtn_Click(object sender, EventArgs e)
        {
            HomeAdm home = new HomeAdm();
            home.Show();
            this.Hide();
        }

        private void AdmConBtn_Click(object sender, EventArgs e)
        {
            AdmCon cons = new AdmCon();
            cons.Show();
            this.Hide();
        }
    }
}
