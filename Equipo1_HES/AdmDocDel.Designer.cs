﻿
namespace Equipo1_HES
{
    partial class AdmDocDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmDocDel));
            this.ModBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AdmDocDGV = new System.Windows.Forms.DataGridView();
            this.DocId = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.AdmHomeBtn = new System.Windows.Forms.Button();
            this.AdmConBtn = new System.Windows.Forms.Button();
            this.AdmDocBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdmDocDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ModBtn
            // 
            this.ModBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.ModBtn.FlatAppearance.BorderSize = 0;
            this.ModBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ModBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModBtn.ForeColor = System.Drawing.Color.White;
            this.ModBtn.Location = new System.Drawing.Point(341, 191);
            this.ModBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(126, 30);
            this.ModBtn.TabIndex = 69;
            this.ModBtn.Text = "Modificar Doctor";
            this.ModBtn.UseVisualStyleBackColor = false;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
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
            this.DelBtn.Location = new System.Drawing.Point(525, 108);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(81, 30);
            this.DelBtn.TabIndex = 68;
            this.DelBtn.Text = "Eliminar";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
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
            this.AddBtn.Location = new System.Drawing.Point(480, 191);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 30);
            this.AddBtn.TabIndex = 67;
            this.AddBtn.Text = "Agregar Doctor";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            // 
            // DocId
            // 
            this.DocId.Location = new System.Drawing.Point(438, 111);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(38, 23);
            this.DocId.TabIndex = 63;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.ForeColor = System.Drawing.Color.DimGray;
            this.txtType.Location = new System.Drawing.Point(326, 111);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(106, 21);
            this.txtType.TabIndex = 62;
            this.txtType.Text = "ID DOCTOR:";
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
            this.panel1.Controls.Add(this.AdmDocBtn);
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
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
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
            // AdmDocBtn
            // 
            this.AdmDocBtn.BackColor = System.Drawing.Color.White;
            this.AdmDocBtn.FlatAppearance.BorderSize = 0;
            this.AdmDocBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdmDocBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AdmDocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdmDocBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdmDocBtn.ForeColor = System.Drawing.Color.Black;
            this.AdmDocBtn.Location = new System.Drawing.Point(31, 177);
            this.AdmDocBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmDocBtn.Name = "AdmDocBtn";
            this.AdmDocBtn.Size = new System.Drawing.Size(159, 30);
            this.AdmDocBtn.TabIndex = 35;
            this.AdmDocBtn.Text = "Administrar Doctores";
            this.AdmDocBtn.UseVisualStyleBackColor = false;
            this.AdmDocBtn.Click += new System.EventHandler(this.AdmDocBtn_Click);
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
            // AdmDocDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AdmDocDGV);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmDocDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmDocDel";
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
        private System.Windows.Forms.TextBox DocId;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button AdmHomeBtn;
        private System.Windows.Forms.Button AdmConBtn;
        private System.Windows.Forms.Button AdmDocBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}