﻿using System;
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
    public partial class AdmConDel : Form
    {
        public AdmConDel()
        {
            InitializeComponent();
            MostrarCons();
        }
        // Hacemos la conexion a la BD
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\OneDrive\Escritorio\CLASES 2022\LP2\PROYECTO FINAL - HES\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");

        private void MostrarCons()
        {
            con.Open();
            string Query = "Select * from ConsultorioTbl"; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            AdmCita.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Ingrese un ID");
            else
            {
                con.Open();
                string query = "delete from ConsultorioTbl where ConId=" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el Consultorio");
                con.Close();
                MostrarCons();
            }
        }

        private void AdmDocBtn_Click(object sender, EventArgs e)
        {
            AdmDocAdd FormAdmDocAdd = new AdmDocAdd();
            FormAdmDocAdd.Show();
            this.Hide();
        }

        private void AdmConBtn_Click(object sender, EventArgs e)
        {
            AdmConAdd FormAdd = new AdmConAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            LoginHES FormLogin = new LoginHES();
            FormLogin.Show();
            this.Hide();
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            AdmConEdit FormEdit = new AdmConEdit();
            FormEdit.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AdmConAdd FormAdd = new AdmConAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmPacDel FormPac = new AdmPacDel();
            FormPac.Show();
            this.Hide();
        }
    }
}
