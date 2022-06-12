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
    public partial class PacCitaEdit : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Nelson\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        public PacCitaEdit()
        {
            InitializeComponent();
            MostarCita();
        }

        private void MostarCita()
        {
            con.Open();
            string Query = "Select * from CitaTbl where PacCi=" + PacLogged.ci + ""; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            AdmCon.DataSource = ds.Tables[0];
            con.Close(); PacCita Cargar = new PacCita();
            Cargar.MostrarCon();

        }

        private void AdmCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
               LblNombre.Text = AdmCon.CurrentRow.Cells[2].Value.ToString();
               LblApellido.Text = AdmCon.CurrentRow.Cells[3].Value.ToString();
               DocCombo.Text = AdmCon.CurrentRow.Cells[4].Value.ToString();
               SpecCombo.Text = AdmCon.CurrentRow.Cells[5].Value.ToString();
               CBoxFecha.Text = AdmCon.CurrentRow.Cells[6].Value.ToString();
              //  CBoxHo.Text = AdmCon.CurrentRow.Cells[7].Value.ToString();

            }

            catch
            {

            }
        }

        private void SpecCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DocCombo.Text = string.Empty;
            CBoxFecha.Items.Clear();
            MostrarDoc();
        }

        private void MostrarDoc()
        {
            
            con.Open();

            MessageBox.Show("Doc");

            if (SpecCombo.SelectedIndex == 0)
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
                MessageBox.Show("Odontologo");
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

            // MostrarFecha();



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

        private void DocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarFecha();
        }

        int i = new int();

        private void MostrarFecha()
        {


            MessageBox.Show("Mostrar fecha " + DocCombo.Text + i);

            if (i > 0)
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

            CargarHora();
        }

        private void CBoxHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBoxHo.Text = string.Empty;
            CargarHora();
        }

        int j = new int();

        private void CargarHora()
        {
            // CBoxHo.Items.Clear();
            if (j!=0)
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
                        MessageBox.Show("Eston en el if ");
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
                else if (SpecCombo.Text == "Pssicologia")
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
                        for (int c = 0; c < 10; c++)
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

                        for (int c = 0; c < 10; c++)
                        {
                            CBoxHo.Items.Add(horaPsicologia[c]);
                        }

                    }
                    con.Close();
                }
            }
            j++;


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            //  string query = "update DoctorTbl set DocName= '" + DName.Text + "', DocPass= '" + DPass.Text + "', DocSpec= '" + DSpec.Text + "', DocCon= '" + DCons.Text + "', DocLastName= '" + DLastName.Text + "', DocUser= '" + DUser.Text + "' where DocId= " + DocId.Text + "";
            string query = "update CitaTbl set DocName= '" + DocCombo.Text + "', DocSpec='" + SpecCombo.Text + "', FechaCon='" + CBoxFecha.Text + "', HoraCon='" + CBoxHo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha modificado doctor");
            con.Close();
            MostarCita();
        }

        private void CBoxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
           // CargarHora();
        }
    }
}
