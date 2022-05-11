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
            MostrarDoc();
        }
        private void AdmDocDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = AdmDocDGV.SelectedRows[0].Cells[0].Value.ToString();
            DName.Text = AdmDocDGV.SelectedRows[0].Cells[1].Value.ToString();
            DPass.Text = AdmDocDGV.SelectedRows[0].Cells[2].Value.ToString();
            DPhone.Text = AdmDocDGV.SelectedRows[0].Cells[3].Value.ToString();

        }
    }
}
