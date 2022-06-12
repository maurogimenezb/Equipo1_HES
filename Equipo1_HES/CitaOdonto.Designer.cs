
namespace Equipo1_HES
{
    partial class CitaOdonto
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
            this.label9 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DocCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(259, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 126;
            this.label9.Text = "NOMBRE:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.LblNombre.Location = new System.Drawing.Point(368, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 20);
            this.LblNombre.TabIndex = 127;
            this.LblNombre.Text = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(250, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 128;
            this.label8.Text = "APELLIDO:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.LblApellido.Location = new System.Drawing.Point(368, 110);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(95, 20);
            this.LblApellido.TabIndex = 129;
            this.LblApellido.Text = "LASTNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(196, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 130;
            this.label3.Text = "Nombre del Doctor:";
            // 
            // DocCombo
            // 
            this.DocCombo.FormattingEnabled = true;
            this.DocCombo.Location = new System.Drawing.Point(368, 164);
            this.DocCombo.Name = "DocCombo";
            this.DocCombo.Size = new System.Drawing.Size(121, 23);
            this.DocCombo.TabIndex = 131;
            this.DocCombo.SelectedIndexChanged += new System.EventHandler(this.DocCombo_SelectedIndexChanged);
            // 
            // CitaOdonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DocCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label9);
            this.Name = "CitaOdonto";
            this.Text = "CitaOdonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DocCombo;
    }
}