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
    public partial class PacCitaElim : Form
    {
        public PacCitaElim()
        {
            InitializeComponent();
            MostrarCon();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nelson\Desktop\Materias 2022\Nelson\Base de datos\BD_HES.mdf;Integrated Security=True;Connect Timeout=30");


        private void MostrarCon()
        {
            con.Open();
            string Query = "Select * from CitaTbl where PacCi=" + PacLogged.ci + ""; // Hace una consulta y selecciona la tabla DoctorTbl
            SqlDataAdapter sda = new SqlDataAdapter(Query, con); // Actua como puente entre el SQL Server y DataSet para guardar datos y lo hace mediante la asignacion fill
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); //Colecciona n numeros de DataTables
            sda.Fill(ds);
            AdmCon.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string[] c = new string[100];
            int cont=0;
            
            if ( CitaId.Text == "")
                MessageBox.Show("Id o CI vacio por favor rellenar para poder eliminar");
            else
            {
                con.Open();
                SqlCommand leer = new SqlCommand("Select * from CitaTbl where PacCi='" +PacLogged.ci +  "'", con);
                SqlDataReader datos = leer.ExecuteReader();
                Boolean Bandera = true;
                while(datos.Read())
                {
                    c[cont] = datos["Id"].ToString();
                    cont++;
                }
                con.Close();

                for (int j = 0; j <= cont; j++)
                {
                    if (c[j] == CitaId.Text)
                    {
                        con.Open();
                        string query = "delete from CitaTbl where Id=" + CitaId.Text + "";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Se ha eliminado su Cita");
                        Bandera = false;
                        con.Close();
                        MostrarCon();
                    }
                }

                if(Bandera == false)
                {
                    MessageBox.Show("Su cita se ha eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error Id elegido incorrecto, Por favor volver a verificar");
                }
                
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            HomePac Atras = new HomePac();
            Atras.Show();
            this.Hide();
        }


    }
}
