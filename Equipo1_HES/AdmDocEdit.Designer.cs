﻿
namespace Equipo1_HES
{
    partial class AdmDocEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmDocEdit));
            this.ModBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AdmDocDGV = new System.Windows.Forms.DataGridView();
            this.DPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DPass = new System.Windows.Forms.TextBox();
            this.DName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.AdmHomeBtn = new System.Windows.Forms.Button();
            this.AdmConBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DocId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdmDocDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ModBtn
            // 
            this.ModBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ModBtn.FlatAppearance.BorderSize = 0;
            this.ModBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ModBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModBtn.ForeColor = System.Drawing.Color.White;
            this.ModBtn.Location = new System.Drawing.Point(527, 104);
            this.ModBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(81, 30);
            this.ModBtn.TabIndex = 69;
            this.ModBtn.Text = "Modificar";
            this.ModBtn.UseVisualStyleBackColor = false;
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Red;
            this.DelBtn.FlatAppearance.BorderSize = 0;
            this.DelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(471, 191);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(126, 30);
            this.DelBtn.TabIndex = 68;
            this.DelBtn.Text = "Eliminar Doctor";
            this.DelBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(323, 191);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 30);
            this.AddBtn.TabIndex = 67;
            this.AddBtn.Text = "Agregar Doctor";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // AdmDocDGV
            // 
            this.AdmDocDGV.BackgroundColor = System.Drawing.Color.White;
            this.AdmDocDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdmDocDGV.GridColor = System.Drawing.Color.White;
            this.AdmDocDGV.Location = new System.Drawing.Point(253, 235);
            this.AdmDocDGV.Name = "AdmDocDGV";
            this.AdmDocDGV.RowTemplate.Height = 25;
            this.AdmDocDGV.Size = new System.Drawing.Size(401, 133);
            this.AdmDocDGV.TabIndex = 70;
            this.AdmDocDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdmDocDGV_CellContentClick);
            // 
            // DPhone
            // 
            this.DPhone.Location = new System.Drawing.Point(377, 144);
            this.DPhone.Name = "DPhone";
            this.DPhone.Size = new System.Drawing.Size(121, 23);
            this.DPhone.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(276, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "TELEFONO:";
            // 
            // DPass
            // 
            this.DPass.Location = new System.Drawing.Point(377, 115);
            this.DPass.Name = "DPass";
            this.DPass.Size = new System.Drawing.Size(121, 23);
            this.DPass.TabIndex = 64;
            // 
            // DName
            // 
            this.DName.Location = new System.Drawing.Point(377, 83);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(121, 23);
            this.DName.TabIndex = 63;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.ForeColor = System.Drawing.Color.DimGray;
            this.txtType.Location = new System.Drawing.Point(285, 83);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(83, 21);
            this.txtType.TabIndex = 62;
            this.txtType.Text = "NOMBRE:";
            // 
            // txtUsers
            // 
            this.txtUsers.AutoSize = true;
            this.txtUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsers.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsers.Location = new System.Drawing.Point(245, 113);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(126, 21);
            this.txtUsers.TabIndex = 61;
            this.txtUsers.Text = "CONTRASEÑA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(606, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 13);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "ADMINISTRAR DOCTORES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.AdmHomeBtn);
            this.panel1.Controls.Add(this.AdmConBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 380);
            this.panel1.TabIndex = 57;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.White;
            this.CerrarBtn.FlatAppearance.BorderSize = 0;
            this.CerrarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CerrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.AdmHomeBtn.BackColor = System.Drawing.Color.White;
            this.AdmHomeBtn.FlatAppearance.BorderSize = 0;
            this.AdmHomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdmHomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AdmHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdmHomeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdmHomeBtn.ForeColor = System.Drawing.Color.Black;
            this.AdmHomeBtn.Location = new System.Drawing.Point(31, 136);
            this.AdmHomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmHomeBtn.Name = "AdmHomeBtn";
            this.AdmHomeBtn.Size = new System.Drawing.Size(159, 30);
            this.AdmHomeBtn.TabIndex = 37;
            this.AdmHomeBtn.Text = "Inicio";
            this.AdmHomeBtn.UseVisualStyleBackColor = false;
            // 
            // AdmConBtn
            // 
            this.AdmConBtn.BackColor = System.Drawing.Color.White;
            this.AdmConBtn.FlatAppearance.BorderSize = 0;
            this.AdmConBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdmConBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AdmConBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdmConBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdmConBtn.ForeColor = System.Drawing.Color.Black;
            this.AdmConBtn.Location = new System.Drawing.Point(31, 219);
            this.AdmConBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmConBtn.Name = "AdmConBtn";
            this.AdmConBtn.Size = new System.Drawing.Size(159, 30);
            this.AdmConBtn.TabIndex = 36;
            this.AdmConBtn.Text = "Administrar Consultorios";
            this.AdmConBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(31, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "Administrar Doctores";
            this.button1.UseVisualStyleBackColor = false;
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
            // DocId
            // 
            this.DocId.Location = new System.Drawing.Point(253, 182);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(37, 23);
            this.DocId.TabIndex = 71;
            // 
            // AdmDocEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AdmDocDGV);
            this.Controls.Add(this.DPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DPass);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmDocEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmDocEdit";
            this.Load += new System.EventHandler(this.AdmDocEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdmDocDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView AdmDocDGV;
        private System.Windows.Forms.TextBox DPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DPass;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Label txtUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button AdmHomeBtn;
        private System.Windows.Forms.Button AdmConBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox DocId;
    }
}