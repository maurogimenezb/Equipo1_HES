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
    public partial class PacCita : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO FINAL - HES\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        public PacCita()
        {
            InitializeComponent();
            MostrarCon();

        }
        int i = new int();


        private void MostrarDoc ()
        {
            /* if (SpecCombo.SelectedIndex == 1)
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
            */




            /* con.Open();  original funcional sin tocar
             SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocSpec='Odontologia'", con);
             SqlDataReader rdr = cmd.ExecuteReader();
            // rdr = cmd.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Columns.Add("DocName");
             dt.Load(rdr);
             DocCombo.ValueMember = "DocName";
             DocCombo.DataSource = dt;
             con.Close();*/
            // int a;
            //con.Open();
            // DocCombo.Items.Add = " ";

           //BoxHo.Text = string.Empty;
            DocCombo.Text = string.Empty;
            CBoxFecha.Text = string.Empty;
            CBoxHo.Text = string.Empty;
            i = 0; 
            con.Open();
          
           
            if ( SpecCombo.SelectedIndex == 0)
            {
                
                 SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocSpec='Medicina General'", con);
                 SqlDataReader rdr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Columns.Add("DocName");
                 dt.Load(rdr);
                 DocCombo.ValueMember = "DocName";
                 DocCombo.DataSource = dt;

            }
            else if (SpecCombo.SelectedIndex == 1)
            {
                
                SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocSpec='Odontologia'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("DocName");
                dt.Load(rdr);
                //MessageBox.Show("Odontologo");
                DocCombo.ValueMember = "DocName";
                DocCombo.DataSource = dt;
              

            }
               
            
            else if (SpecCombo.SelectedIndex == 2)
            {
               
                SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocSpec='Psicologia'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("DocName");
                dt.Load(rdr);
                DocCombo.ValueMember = "DocName";
                DocCombo.DataSource = dt;

            }
            con.Close();
           
            MostrarFecha();



            /*  con.Open();
              SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocSpec='Odontologia'", con);
              SqlCommand cmd1 = new SqlCommand("Select * from DoctorTbl where DocSpec='Psicologia'", con);
              SqlDataReader rdr = cmd.ExecuteReader();
              SqlDataReader rdr1 = cmd1 .ExecuteReader();
              DataTable dt = new DataTable();
              dt.Columns.Add("DocName");
              dt.Load(rdr);
              DocCombo.ValueMember = "DocName";
              DocCombo.DataSource = dt;
              con.Close();*/


        }
        

        private void MostrarFecha()
        {
            
            if (i>0)
            {

               
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocName='" + DocCombo.SelectedText + "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("DocDisp");
                dt.Load(rdr);
                CBoxFecha.ValueMember = "DocDisp";
                CBoxFecha.DataSource = dt;
                con.Close();
                
            }
            i++;
            CBoxHo.Items.Clear();
            CargarHora();
        }

        private void CargarHora()
        {
            
            if (CBoxFecha.Text != "")
            {

                if (SpecCombo.Text == "Medicina General")
                {
                    // MessageBox.Show("Estoy en medicina ");
                    string[] horaMedicina = new string[10];
                    horaMedicina[0] = "07:00";
                    horaMedicina[1] = "08:00";
                    horaMedicina[2] = "09:00";
                    horaMedicina[3] = "10:00";
                    horaMedicina[4] = "11:00";
                    horaMedicina[5] = "13:00";
                    horaMedicina[6] = "14:00";
                    horaMedicina[7] = "15:00";
                    horaMedicina[8] = "16:00";
                    horaMedicina[9] = "17:00";

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CitaTbl where FechaCon='" + CBoxFecha.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    // MessageBox.Show("Estoy en medicina " + dt.Rows[0][0].ToString());
                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        // MessageBox.Show("Eston en el if ");
                        con.Close();
                        for (int c = 0; c < 10; c++)
                        {
                            con.Open();
                            SqlCommand leer = new SqlCommand("Select * from CitaTbl where HoraCon='" + horaMedicina[c] + "' and FechaCon='" + CBoxFecha.Text + "'", con);
                            SqlDataReader datos = leer.ExecuteReader();

                            if (datos.Read() == false)
                            {
                                CBoxHo.Items.Add(horaMedicina[c]);
                            }
                            con.Close();
                        }

                    }
                    else
                    {

                        for (int c = 0; c < 10; c++)
                        {
                            CBoxHo.Items.Add(horaMedicina[c]);
                        }

                    }
                    con.Close();


                }
                else if (SpecCombo.Text == "Odontologia")
                {

                    string[] horaOdonto = new string[10];
                    horaOdonto[0] = "07:00";
                    horaOdonto[1] = "08:30";
                    horaOdonto[2] = "09:30";
                    horaOdonto[3] = "10:30";
                    horaOdonto[4] = "11:30";
                    horaOdonto[5] = "13:30";
                    horaOdonto[6] = "14:30";
                    horaOdonto[7] = "15:30";
                    horaOdonto[8] = "16:30";
                    horaOdonto[9] = "17:30";

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CitaTbl where FechaCon='" + CBoxFecha.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    // MessageBox.Show("Estoy en odontologia " + dt.Rows[0][0].ToString());
                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        
                        con.Close();
                        for (int c = 0; c < 10; c++)
                        {
                            con.Open();
                            SqlCommand leer = new SqlCommand("Select * from CitaTbl where HoraCon='" + horaOdonto[c] + "' and FechaCon='" + CBoxFecha.Text + "'", con);
                            SqlDataReader datos = leer.ExecuteReader();

                            if (datos.Read() == false)
                            {
                                CBoxHo.Items.Add(horaOdonto[c]);
                            }
                            con.Close();
                        }

                    }
                    else
                    {
                        // MessageBox.Show("Eston en el else ");
                        for (int c = 0; c < 10; c++)
                        {
                            CBoxHo.Items.Add(horaOdonto[c]);
                        }

                    }
                    con.Close();




                }
                else if (SpecCombo.Text == "Psicologia")
                {

                    string[] horaPsicologia = new string[10];
                    horaPsicologia[0] = "08:00";
                    horaPsicologia[1] = "09:30";
                    horaPsicologia[2] = "10:30";
                    horaPsicologia[3] = "11:30";
                    horaPsicologia[4] = "13:30";
                    horaPsicologia[5] = "14:30";
                    horaPsicologia[6] = "15:30";
                    horaPsicologia[7] = "16:30";
                    horaPsicologia[8] = "17:30";

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CitaTbl where FechaCon='" + CBoxFecha.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        // MessageBox.Show("Eston en el if ");
                        con.Close();
                        for (int c = 0; c < 9; c++)
                        {
                            con.Open();
                            SqlCommand leer = new SqlCommand("Select * from CitaTbl where HoraCon='" + horaPsicologia[c] + "' and FechaCon='" + CBoxFecha.Text + "'", con);
                            SqlDataReader datos = leer.ExecuteReader();

                            if (datos.Read() == false)
                            {
                                CBoxHo.Items.Add(horaPsicologia[c]);
                            }
                            con.Close();
                        }

                    }
                    else
                    {

                        for (int c = 0; c < 9; c++)
                        {
                            CBoxHo.Items.Add(horaPsicologia[c]);
                        }

                    }
                    con.Close();

                }
            }
            
        }

        private void SpecCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DocCombo.Text= string.Empty;
            MostrarDoc();   
        }

        public void MostrarCon()
        {
            con.Open();
            string Query = "Select * from CitaTbl where PacCi=" +PacLogged.ci+""; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            AdmCon.DataSource = ds.Tables[0];
            con.Close();
        }



        private void CBoxHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CBoxHo.Items.Clear();
            //CargarHora();
          
        }

        private void CBoxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha seleccionado correctamente");

            MostrarFecha();
           
        }

        private void SpecCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (SpecCombo.Text == "" || DocCombo.Text == "" || CBoxFecha.Text == "" || CBoxHo.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CitaTbl(PacCi,PacName,PacSurn,DocName,DocSpec,FechaCon,HoraCon)values(@PC,@PN,@PA,@DN,@DE,@FC,@OC)", con);
                    cmd.Parameters.AddWithValue("@PC", PacLogged.ci);
                    cmd.Parameters.AddWithValue("@PN", PacLogged.name);
                    cmd.Parameters.AddWithValue("@PA", PacLogged.lastname);
                    cmd.Parameters.AddWithValue("@DN", DocCombo.Text);
                    // cmd.Parameters.AddWithValue("@DE", DocSurn.Value.Date);
                    cmd.Parameters.AddWithValue("@DE", SpecCombo.Text);
                    cmd.Parameters.AddWithValue("@FC", CBoxFecha.Text);
                    cmd.Parameters.AddWithValue("@OC", CBoxHo.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            MostrarCon();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
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

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLoginHES = new LoginHES();
            FormLoginHES.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdmCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
