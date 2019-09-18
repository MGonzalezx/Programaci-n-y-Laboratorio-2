namespace Clase_08.WindowsForms
{
    partial class FrmCatedra
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
            this.groupAlumnos = new System.Windows.Forms.GroupBox();
            this.groupAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupAlumnos.SuspendLayout();
            this.groupAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAlumnos
            // 
            this.groupAlumnos.Controls.Add(this.button3);
            this.groupAlumnos.Controls.Add(this.button2);
            this.groupAlumnos.Controls.Add(this.button1);
            this.groupAlumnos.Controls.Add(this.listBox1);
            this.groupAlumnos.Location = new System.Drawing.Point(12, 12);
            this.groupAlumnos.Name = "groupAlumnos";
            this.groupAlumnos.Size = new System.Drawing.Size(820, 338);
            this.groupAlumnos.TabIndex = 0;
            this.groupAlumnos.TabStop = false;
            this.groupAlumnos.Text = "Alumnos";
            // 
            // groupAlumnosCalificados
            // 
            this.groupAlumnosCalificados.Controls.Add(this.listBox2);
            this.groupAlumnosCalificados.Location = new System.Drawing.Point(12, 356);
            this.groupAlumnosCalificados.Name = "groupAlumnosCalificados";
            this.groupAlumnosCalificados.Size = new System.Drawing.Size(820, 291);
            this.groupAlumnosCalificados.TabIndex = 0;
            this.groupAlumnosCalificados.TabStop = false;
            this.groupAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(751, 251);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(147, 68);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 511);
            this.Controls.Add(this.groupAlumnosCalificados);
            this.Controls.Add(this.groupAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.Load += new System.EventHandler(this.FrmCatedra_Load);
            this.groupAlumnos.ResumeLayout(false);
            this.groupAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAlumnos;
        private System.Windows.Forms.GroupBox groupAlumnosCalificados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}