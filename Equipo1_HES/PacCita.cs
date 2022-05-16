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
        public PacCita()
        {
            InitializeComponent();
 
        }
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO HES\Base de Datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");


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




            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DoctorTbl where DocSpec='Odontologia'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocName");
            dt.Load(rdr);
            DocCombo.ValueMember = "DocName";
            DocCombo.DataSource = dt;
            con.Close();
            
        }

        private void SpecCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarDoc();
        }
    }
}
