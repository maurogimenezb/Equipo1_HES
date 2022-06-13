using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Equipo1_HES
{
    public partial class CitaOdonto : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO FINAL - HES\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        public CitaOdonto()
        {
            InitializeComponent();

            LblNombre.Text = PacLogged.name;
            LblApellido.Text = PacLogged.lastname;
        }

        private void DocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nombre();
        }

        private void Nombre()
        {

        }
    }
}
