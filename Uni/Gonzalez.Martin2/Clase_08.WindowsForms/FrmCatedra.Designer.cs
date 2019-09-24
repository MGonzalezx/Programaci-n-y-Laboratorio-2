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
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupAlumnos.SuspendLayout();
            this.groupAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAlumnos
            // 
            this.groupAlumnos.Controls.Add(this.cmbOrden);
            this.groupAlumnos.Controls.Add(this.btnModificar);
            this.groupAlumnos.Controls.Add(this.btnCalificar);
            this.groupAlumnos.Controls.Add(this.btnAgregar);
            this.groupAlumnos.Controls.Add(this.listBox1);
            this.groupAlumnos.Location = new System.Drawing.Point(12, 12);
            this.groupAlumnos.Name = "groupAlumnos";
            this.groupAlumnos.Size = new System.Drawing.Size(638, 338);
            this.groupAlumnos.TabIndex = 0;
            this.groupAlumnos.TabStop = false;
            this.groupAlumnos.Text = "Alumnos";
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Location = new System.Drawing.Point(30, 311);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(592, 21);
            this.cmbOrden.TabIndex = 4;
            this.cmbOrden.SelectedIndexChanged += new System.EventHandler(this.cmbOrden_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(547, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(278, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 251);
            this.listBox1.TabIndex = 0;
            // 
            // groupAlumnosCalificados
            // 
            this.groupAlumnosCalificados.Controls.Add(this.listBox2);
            this.groupAlumnosCalificados.Location = new System.Drawing.Point(12, 356);
            this.groupAlumnosCalificados.Name = "groupAlumnosCalificados";
            this.groupAlumnosCalificados.Size = new System.Drawing.Size(638, 263);
            this.groupAlumnosCalificados.TabIndex = 0;
            this.groupAlumnosCalificados.TabStop = false;
            this.groupAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(30, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(592, 212);
            this.listBox2.TabIndex = 1;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 629);
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox cmbOrden;
    }
}