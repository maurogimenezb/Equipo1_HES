using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo1_HES
{
    public partial class HomePac : Form
    {
        public HomePac()
        {
            InitializeComponent();
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            PacProf FormPacProf = new PacProf();
            FormPacProf.Show(); 
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES cerrar = new LoginHES();
            cerrar.Show();
            this.Hide();
        }
    }
}
