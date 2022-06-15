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
    public partial class DocProf : Form
    {
        public DocProf()
        {
            InitializeComponent();
        }

        private void DocProf_Load(object sender, EventArgs e)
        {
            LblName.Text = DocLogged.name;
            LblLastName.Text = DocLogged.lastname;
            LblUser.Text = DocLogged.user;
            LblSpec.Text = DocLogged.spec;
            LblCons.Text = DocLogged.cons;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocDispAdd FormDocDispAdd = new DocDispAdd();
            FormDocDispAdd.Show();
            this.Hide();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            CunsultasDoc Consultas = new CunsultasDoc();
            Consultas.Show();
            this.Hide();
        }
    }
}
