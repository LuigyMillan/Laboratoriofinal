
namespace Laboratorio
{
    partial class MenuL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuL));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistroExam = new System.Windows.Forms.Button();
            this.btnAtencionNacio = new System.Windows.Forms.Button();
            this.btnRegistroPaci = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LABORATORIO MÉDICO HERMANOS CAMPUZANO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistroExam
            // 
            this.btnRegistroExam.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRegistroExam.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistroExam.Location = new System.Drawing.Point(140, 78);
            this.btnRegistroExam.Name = "btnRegistroExam";
            this.btnRegistroExam.Size = new System.Drawing.Size(102, 53);
            this.btnRegistroExam.TabIndex = 6;
            this.btnRegistroExam.Text = "Registro del examen";
            this.btnRegistroExam.UseVisualStyleBackColor = false;
            this.btnRegistroExam.Click += new System.EventHandler(this.btnRegistroExam_Click);
            // 
            // btnAtencionNacio
            // 
            this.btnAtencionNacio.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAtencionNacio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtencionNacio.Location = new System.Drawing.Point(21, 148);
            this.btnAtencionNacio.Name = "btnAtencionNacio";
            this.btnAtencionNacio.Size = new System.Drawing.Size(102, 53);
            this.btnAtencionNacio.TabIndex = 5;
            this.btnAtencionNacio.Text = "Atención Nacional";
            this.btnAtencionNacio.UseVisualStyleBackColor = false;
            this.btnAtencionNacio.Click += new System.EventHandler(this.btnAtencionNacio_Click);
            // 
            // btnRegistroPaci
            // 
            this.btnRegistroPaci.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRegistroPaci.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistroPaci.Location = new System.Drawing.Point(21, 78);
            this.btnRegistroPaci.Name = "btnRegistroPaci";
            this.btnRegistroPaci.Size = new System.Drawing.Size(102, 53);
            this.btnRegistroPaci.TabIndex = 4;
            this.btnRegistroPaci.Text = "Registro de pacientes";
            this.btnRegistroPaci.UseVisualStyleBackColor = false;
            this.btnRegistroPaci.Click += new System.EventHandler(this.btnRegistroPaci_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(140, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRegistroPaci);
            this.groupBox1.Controls.Add(this.btnRegistroExam);
            this.groupBox1.Controls.Add(this.btnAtencionNacio);
            this.groupBox1.Location = new System.Drawing.Point(172, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(-2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 43);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // MenuL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Laboratorio.Properties.Resources.Imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuL";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroExam;
        private System.Windows.Forms.Button btnAtencionNacio;
        private System.Windows.Forms.Button btnRegistroPaci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}