
namespace Equipo1_HES
{
    partial class CunsultasDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CunsultasDoc));
            this.ConsultasDoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdmDocBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasDoc
            // 
            this.ConsultasDoc.BackgroundColor = System.Drawing.Color.White;
            this.ConsultasDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDoc.GridColor = System.Drawing.Color.White;
            this.ConsultasDoc.Location = new System.Drawing.Point(240, 136);
            this.ConsultasDoc.Name = "ConsultasDoc";
            this.ConsultasDoc.RowTemplate.Height = 25;
            this.ConsultasDoc.Size = new System.Drawing.Size(408, 184);
            this.ConsultasDoc.TabIndex = 129;
            this.ConsultasDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultasDoc_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.BtnConsulta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AdmDocBtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 383);
            this.panel1.TabIndex = 130;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(31, 340);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 30);
            this.button4.TabIndex = 38;
            this.button4.Text = "Cerrar Sesion";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(71, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(330, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 24);
            this.label6.TabIndex = 131;
            this.label6.Text = "CONSULTAS PREVISTAS";
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAtras.BackgroundImage")));
            this.BtnAtras.FlatAppearance.BorderSize = 0;
            this.BtnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAtras.ForeColor = System.Drawing.Color.White;
            this.BtnAtras.Location = new System.Drawing.Point(386, 325);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(100, 30);
            this.BtnAtras.TabIndex = 132;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Visible = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(653, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 22);
            this.btnCerrar.TabIndex = 133;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(605, 19);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(32, 13);
            this.BtnMin.TabIndex = 134;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.BackgroundImage")));
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConsulta.ForeColor = System.Drawing.Color.Black;
            this.BtnConsulta.Location = new System.Drawing.Point(31, 210);
            this.BtnConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(159, 30);
            this.BtnConsulta.TabIndex = 44;
            this.BtnConsulta.Text = "Consultar Pacientes";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(31, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 43;
            this.button1.Text = "Registrar Disponibilidad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdmDocBtn
            // 
            this.AdmDocBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdmDocBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdmDocBtn.BackgroundImage")));
            this.AdmDocBtn.FlatAppearance.BorderSize = 0;
            this.AdmDocBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AdmDocBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AdmDocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdmDocBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdmDocBtn.ForeColor = System.Drawing.Color.Black;
            this.AdmDocBtn.Location = new System.Drawing.Point(31, 128);
            this.AdmDocBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmDocBtn.Name = "AdmDocBtn";
            this.AdmDocBtn.Size = new System.Drawing.Size(159, 30);
            this.AdmDocBtn.TabIndex = 42;
            this.AdmDocBtn.Text = "Perfil";
            this.AdmDocBtn.UseVisualStyleBackColor = false;
            this.AdmDocBtn.Click += new System.EventHandler(this.AdmDocBtn_Click);
            // 
            // CunsultasDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConsultasDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CunsultasDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CunsultasDoc";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDoc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultasDoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AdmDocBtn;
    }
}