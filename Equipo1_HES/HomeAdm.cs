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
    public partial class HomeAdm : Form
    {
        public HomeAdm()
        {
            InitializeComponent();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES cerrar = new LoginHES();
            cerrar.Show();
            this.Hide();
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            AdmDocAdd doc = new AdmDocAdd();
            doc.Show();
            this.Hide();
        }

        private void AdmConBtn_Click(object sender, EventArgs e)
        {
            AdmCon cons = new AdmCon();
            cons.Show();
            this.Hide();
        }
    }
}
