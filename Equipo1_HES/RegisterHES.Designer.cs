
namespace Equipo1_HES
{
    partial class RegisterHES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterHES));
            this.PPass = new System.Windows.Forms.TextBox();
            this.PUser = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.Label();
            this.PGen = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AtrasBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PDOB = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PCI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PPass
            // 
            this.PPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PPass.Location = new System.Drawing.Point(423, 159);
            this.PPass.Name = "PPass";
            this.PPass.Size = new System.Drawing.Size(121, 16);
            this.PPass.TabIndex = 37;
            // 
            // PUser
            // 
            this.PUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PUser.Location = new System.Drawing.Point(423, 125);
            this.PUser.Name = "PUser";
            this.PUser.Size = new System.Drawing.Size(121, 16);
            this.PUser.TabIndex = 36;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.ForeColor = System.Drawing.Color.DimGray;
            this.txtType.Location = new System.Drawing.Point(335, 123);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(86, 21);
            this.txtType.TabIndex = 35;
            this.txtType.Text = "USUARIO:";
            // 
            // PGen
            // 
            this.PGen.BackColor = System.Drawing.SystemColors.Window;
            this.PGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PGen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PGen.FormattingEnabled = true;
            this.PGen.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.PGen.Location = new System.Drawing.Point(423, 190);
            this.PGen.Name = "PGen";
            this.PGen.Size = new System.Drawing.Size(121, 25);
            this.PGen.TabIndex = 34;
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(335, 188);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(82, 21);
            this.txtPass.TabIndex = 33;
            this.txtPass.Text = "GENERO:";
            // 
            // txtUsers
            // 
            this.txtUsers.AutoSize = true;
            this.txtUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsers.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsers.Location = new System.Drawing.Point(295, 153);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(126, 21);
            this.txtUsers.TabIndex = 32;
            this.txtUsers.Text = "CONTRASEÑA:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(655, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 22);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(617, 11);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 13);
            this.btnMin.TabIndex = 30;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.White;
            this.RegisterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterBtn.BackgroundImage")));
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(397, 330);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(100, 30);
            this.RegisterBtn.TabIndex = 27;
            this.RegisterBtn.Text = "   Registrar";
            this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.AtrasBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 380);
            this.panel1.TabIndex = 25;
            // 
            // AtrasBtn
            // 
            this.AtrasBtn.BackColor = System.Drawing.Color.Transparent;
            this.AtrasBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AtrasBtn.BackgroundImage")));
            this.AtrasBtn.FlatAppearance.BorderSize = 0;
            this.AtrasBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AtrasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AtrasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtrasBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AtrasBtn.ForeColor = System.Drawing.Color.Black;
            this.AtrasBtn.Location = new System.Drawing.Point(33, 339);
            this.AtrasBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtrasBtn.Name = "AtrasBtn";
            this.AtrasBtn.Size = new System.Drawing.Size(160, 30);
            this.AtrasBtn.TabIndex = 43;
            this.AtrasBtn.Text = "Volver Atras";
            this.AtrasBtn.UseVisualStyleBackColor = false;
            this.AtrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(346, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "CREAR UNA CUENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(322, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "TELEFONO:";
            // 
            // PPhone
            // 
            this.PPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PPhone.Location = new System.Drawing.Point(423, 228);
            this.PPhone.Name = "PPhone";
            this.PPhone.Size = new System.Drawing.Size(121, 16);
            this.PPhone.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(295, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "NACIMIENTO:";
            // 
            // PDOB
            // 
            this.PDOB.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PDOB.CalendarMonthBackground = System.Drawing.Color.White;
            this.PDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PDOB.Location = new System.Drawing.Point(423, 258);
            this.PDOB.Name = "PDOB";
            this.PDOB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PDOB.ShowCheckBox = true;
            this.PDOB.Size = new System.Drawing.Size(121, 23);
            this.PDOB.TabIndex = 42;
            this.PDOB.Value = new System.DateTime(2022, 5, 12, 22, 24, 42, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(423, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 1);
            this.panel2.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(423, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 1);
            this.panel3.TabIndex = 95;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(423, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 1);
            this.panel4.TabIndex = 96;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(423, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 1);
            this.panel5.TabIndex = 99;
            // 
            // PLastName
            // 
            this.PLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PLastName.Location = new System.Drawing.Point(423, 94);
            this.PLastName.Name = "PLastName";
            this.PLastName.Size = new System.Drawing.Size(121, 16);
            this.PLastName.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(331, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 97;
            this.label1.Text = "APELLIDO:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(423, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 1);
            this.panel6.TabIndex = 102;
            // 
            // PName
            // 
            this.PName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PName.Location = new System.Drawing.Point(423, 64);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(121, 16);
            this.PName.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(335, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 100;
            this.label5.Text = "NOMBRE:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(417, 309);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(121, 1);
            this.panel7.TabIndex = 105;
            // 
            // PCI
            // 
            this.PCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PCI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PCI.Location = new System.Drawing.Point(417, 291);
            this.PCI.Name = "PCI";
            this.PCI.Size = new System.Drawing.Size(121, 16);
            this.PCI.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(343, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 103;
            this.label6.Text = "CI NRO:";
            // 
            // RegisterHES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.PCI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PPass);
            this.Controls.Add(this.PUser);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.PGen);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterHES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterHES";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PPass;
        private System.Windows.Forms.TextBox PUser;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.ComboBox PGen;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.Label txtUsers;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker PDOB;
        private System.Windows.Forms.Button AtrasBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox PLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox PCI;
        private System.Windows.Forms.Label label6;
    }
}