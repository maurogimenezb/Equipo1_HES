
namespace Equipo1_HES
{
    partial class PacCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CitaBtn = new System.Windows.Forms.Button();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.AdmHomeBtn = new System.Windows.Forms.Button();
            this.AdmDocBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RegLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocId = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SpecCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AdmCon = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxFecha = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBoxHo = new System.Windows.Forms.ComboBox();
            this.DocCombo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmCon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.CitaBtn);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.AdmHomeBtn);
            this.panel1.Controls.Add(this.AdmDocBtn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 380);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CitaBtn
            // 
            this.CitaBtn.BackColor = System.Drawing.Color.Transparent;
            this.CitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CitaBtn.BackgroundImage")));
            this.CitaBtn.FlatAppearance.BorderSize = 0;
            this.CitaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CitaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CitaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CitaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CitaBtn.ForeColor = System.Drawing.Color.Black;
            this.CitaBtn.Location = new System.Drawing.Point(31, 220);
            this.CitaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CitaBtn.Name = "CitaBtn";
            this.CitaBtn.Size = new System.Drawing.Size(159, 30);
            this.CitaBtn.TabIndex = 39;
            this.CitaBtn.Text = "Reservar Cita";
            this.CitaBtn.UseVisualStyleBackColor = false;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Transparent;
            this.CerrarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.BackgroundImage")));
            this.CerrarBtn.FlatAppearance.BorderSize = 0;
            this.CerrarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CerrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CerrarBtn.ForeColor = System.Drawing.Color.Black;
            this.CerrarBtn.Location = new System.Drawing.Point(31, 340);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(159, 30);
            this.CerrarBtn.TabIndex = 38;
            this.CerrarBtn.Text = "Cerrar Sesion";
            this.CerrarBtn.UseVisualStyleBackColor = false;
            // 
            // AdmHomeBtn
            // 
            this.AdmHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdmHomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdmHomeBtn.BackgroundImage")));
            this.AdmHomeBtn.FlatAppearance.BorderSize = 0;
            this.AdmHomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AdmHomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AdmHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdmHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdmHomeBtn.ForeColor = System.Drawing.Color.Black;
            this.AdmHomeBtn.Location = new System.Drawing.Point(31, 136);
            this.AdmHomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmHomeBtn.Name = "AdmHomeBtn";
            this.AdmHomeBtn.Size = new System.Drawing.Size(159, 30);
            this.AdmHomeBtn.TabIndex = 37;
            this.AdmHomeBtn.Text = "Inicio";
            this.AdmHomeBtn.UseVisualStyleBackColor = false;
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
            this.AdmDocBtn.Location = new System.Drawing.Point(31, 177);
            this.AdmDocBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmDocBtn.Name = "AdmDocBtn";
            this.AdmDocBtn.Size = new System.Drawing.Size(159, 30);
            this.AdmDocBtn.TabIndex = 35;
            this.AdmDocBtn.Text = "Perfil";
            this.AdmDocBtn.UseVisualStyleBackColor = false;
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
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegLbl.Location = new System.Drawing.Point(281, 356);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(151, 24);
            this.RegLbl.TabIndex = 120;
            this.RegLbl.Text = "¡SIN REGISTRO!";
            this.RegLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 119;
            this.label2.Text = "DISPONIBILIDAD:";
            // 
            // DocId
            // 
            this.DocId.Location = new System.Drawing.Point(225, 15);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(66, 23);
            this.DocId.TabIndex = 118;
            this.DocId.Visible = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(519, 339);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 30);
            this.AddBtn.TabIndex = 116;
            this.AddBtn.Text = "Agregar";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.ForeColor = System.Drawing.Color.DimGray;
            this.txtType.Location = new System.Drawing.Point(228, 85);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(132, 20);
            this.txtType.TabIndex = 115;
            this.txtType.Text = "ESPECIALIDAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "ADMINISTRAR CONSULTORIOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(651, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(613, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 13);
            this.pictureBox2.TabIndex = 112;
            this.pictureBox2.TabStop = false;
            // 
            // SpecCombo
            // 
            this.SpecCombo.FormattingEnabled = true;
            this.SpecCombo.Items.AddRange(new object[] {
            "Medicina General",
            "Odontologia",
            "Psicologia"});
            this.SpecCombo.Location = new System.Drawing.Point(366, 85);
            this.SpecCombo.Name = "SpecCombo";
            this.SpecCombo.Size = new System.Drawing.Size(121, 23);
            this.SpecCombo.TabIndex = 121;
            this.SpecCombo.SelectedIndexChanged += new System.EventHandler(this.SpecCombo_SelectedIndexChanged);
            this.SpecCombo.SelectionChangeCommitted += new System.EventHandler(this.SpecCombo_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(228, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Nombre del Doctor:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.LblNombre.Location = new System.Drawing.Point(317, 51);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 20);
            this.LblNombre.TabIndex = 124;
            this.LblNombre.Text = "NAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(228, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 125;
            this.label9.Text = "NOMBRE:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.LblApellido.Location = new System.Drawing.Point(517, 51);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(95, 20);
            this.LblApellido.TabIndex = 126;
            this.LblApellido.Text = "LASTNAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(419, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 127;
            this.label8.Text = "APELLIDO:";
            // 
            // AdmCon
            // 
            this.AdmCon.BackgroundColor = System.Drawing.Color.White;
            this.AdmCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdmCon.GridColor = System.Drawing.Color.White;
            this.AdmCon.Location = new System.Drawing.Point(244, 220);
            this.AdmCon.Name = "AdmCon";
            this.AdmCon.RowTemplate.Height = 25;
            this.AdmCon.Size = new System.Drawing.Size(401, 114);
            this.AdmCon.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(225, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "Fecha disponible:";
            // 
            // CBoxFecha
            // 
            this.CBoxFecha.FormattingEnabled = true;
            this.CBoxFecha.Location = new System.Drawing.Point(354, 184);
            this.CBoxFecha.Name = "CBoxFecha";
            this.CBoxFecha.Size = new System.Drawing.Size(104, 23);
            this.CBoxFecha.TabIndex = 131;
            this.CBoxFecha.SelectedIndexChanged += new System.EventHandler(this.CBoxFecha_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(464, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 133;
            this.label4.Text = "Hora de Consulta:";
            // 
            // CBoxHo
            // 
            this.CBoxHo.FormattingEnabled = true;
            this.CBoxHo.Location = new System.Drawing.Point(607, 184);
            this.CBoxHo.Name = "CBoxHo";
            this.CBoxHo.Size = new System.Drawing.Size(68, 23);
            this.CBoxHo.TabIndex = 134;
            this.CBoxHo.SelectedIndexChanged += new System.EventHandler(this.CBoxHo_SelectedIndexChanged);
            // 
            // DocCombo
            // 
            this.DocCombo.FormattingEnabled = true;
            this.DocCombo.Location = new System.Drawing.Point(380, 125);
            this.DocCombo.Name = "DocCombo";
            this.DocCombo.Size = new System.Drawing.Size(98, 23);
            this.DocCombo.TabIndex = 135;
            this.DocCombo.SelectedIndexChanged += new System.EventHandler(this.DocCombo_SelectedIndexChanged);
            // 
            // PacCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.DocCombo);
            this.Controls.Add(this.CBoxHo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBoxFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdmCon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecCombo);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PacCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacCita";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CitaBtn;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button AdmHomeBtn;
        private System.Windows.Forms.Button AdmDocBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocId;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SpecCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView AdmCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxHo;
        private System.Windows.Forms.ComboBox DocCombo;
    }
}