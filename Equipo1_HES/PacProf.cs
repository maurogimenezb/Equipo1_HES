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
            LblPass.Text = PacLogged.pass;
            LblSex.Text = PacLogged.sexo;
            LblPhone.Text = PacLogged.phone;
            LblDOB.Text = PacLogged.nac;

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
    }
}
