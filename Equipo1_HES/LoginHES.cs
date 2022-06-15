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
    public partial class LoginHES : Form
    {
        // Hacemos la conexion a la BD
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO FINAL - HES\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Hospital 2.0\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        //conexionbd conexion = new conexionbd();
        // SqlConnection consql = new SqlConnection();
        public LoginHES()
        {
            InitializeComponent();
          //  consql.ConnectionString = conexion.cadena_conexion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione su rol");
            } else if (LoginRol.SelectedIndex == 0)
            {
                if (LoginUser.Text == "" || LoginPass.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario y contraseña");
                } else if (LoginUser.Text == "admin" && LoginPass.Text == "123")
                {
                    AdmDocAdd Obj = new AdmDocAdd();
                    Obj.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Nombre de administrador y contraseña incorrecto");
                }

            } else if (LoginRol.SelectedIndex == 1)
            {
                if (LoginUser.Text == "" || LoginPass.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario y contraseña");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocUser='" + LoginUser.Text + "' and DocPass='" + LoginPass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //Para mostrar en los TextBox
                        SqlCommand leer = new SqlCommand("Select * from DoctorTbl where DocUser='" + LoginUser.Text + "'", con);
                        SqlDataReader datos = leer.ExecuteReader();

                        if (datos.Read() == true)
                        {
                            DocLogged.name = datos["DocName"].ToString();
                            DocLogged.lastname = datos["DocLastName"].ToString();
                            DocLogged.pass = datos["DocPass"].ToString();
                            DocLogged.spec = datos["DocSpec"].ToString();
                            DocLogged.cons = datos["DocCon"].ToString();
                            DocLogged.user = datos["DocUser"].ToString();
                            DocLogged.id = datos["DocId"].ToString();
                            DocLogged.disp = datos["DocDisp"].ToString();


                        }
                        datos.Close();
                        //Termina para mostrar TextBox
                        DocProf DocProf = new DocProf();
                        DocProf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor no encontrado");
                    }
                    con.Close();

                }

            } else
            {
                if (LoginUser.Text == "" || LoginPass.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario y contraseña");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PacienteTbl where PacUser='" + LoginUser.Text + "' and PacPass='" + LoginPass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //Para mostrar en los TextBox
                        SqlCommand leer = new SqlCommand("Select * from PacienteTbl where PacUser='" + LoginUser.Text + "'", con);
                        SqlDataReader datos = leer.ExecuteReader();

                        if(datos.Read()==true)
                        {
                            /* paciente.textNombre.Text = datos["PacName"].ToString();
                             paciente.textCodigo.Text = datos["PacPass"].ToString();
                             paciente.textSexo.Text = datos["PacGen"].ToString();
                             paciente.textTelefono.Text = datos["PacPhone"].ToString(); */
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
                        //Termina para mostrar TextBox
                        PacProf PacProf = new PacProf();
                        PacProf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Paciente no encontrado");
                    }
                    con.Close ();

                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterHES register = new RegisterHES();
            register.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
