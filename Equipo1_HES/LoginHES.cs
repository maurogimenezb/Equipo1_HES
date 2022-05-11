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

        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO HES\Base de Datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

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
                    HomeAdm Obj = new HomeAdm();
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
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocName='"+LoginUser.Text+"' and DocPass='"+LoginPass.Text+"'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        /*string query;
                        query = "Select * from DoctorTbl where DocName='"+LoginUser+ "' and DocPass='" + LoginPass + "' ";
                        SqlCommand conx = new SqlCommand(query, con);
                        SqlDataReader drLogin;
                        con.Open();
                        drLogin = conx.ExecuteReader();

                        if(drLogin.Read())
                        {
                            LoggedInUser.User = drLogin["DocName"].ToString();
                           // LoggedInUser.UserName = drLogin[""].ToString()+" "+drLogin[];

                            drLogin.Close();
                            conx.Dispose();
                            con.Close();
                        

                        }*/
                        HomeDoc doctor = new HomeDoc();
                        doctor.Show();
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
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PacienteTbl where PacName='" + LoginUser.Text + "' and PacPass='" + LoginPass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        HomePac paciente = new HomePac();
                        paciente.Show();
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
    }
}
