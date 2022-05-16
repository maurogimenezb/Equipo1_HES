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
    public partial class PacProf : Form
    {
        public PacProf()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PacProfUpd FormProfUpd = new PacProfUpd();
            FormProfUpd.Show();
            this.Hide();
        }

        private void PacProf_Load(object sender, EventArgs e)
        {
            LblName.Text = PacLogged.name;
            LblLastName.Text = PacLogged.lastname;
            LblUser.Text = PacLogged.user;
            LblPass.Text = PacLogged.pass;
            LblSex.Text = PacLogged.gen;
            LblPhone.Text = PacLogged.phone;
            LblDOB.Text = PacLogged.dob;
            LblCI.Text = PacLogged.ci;


        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLoginHES = new LoginHES();
            FormLoginHES.Show();
            this.Hide();
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            PacProf FormPacProf = new PacProf();
            FormPacProf.Show();
            this.Hide();
        }

        private void AdmHomeBtn_Click(object sender, EventArgs e)
        {
            HomePac FormHomePac = new HomePac();
            FormHomePac.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
