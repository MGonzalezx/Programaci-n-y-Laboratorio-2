namespace Clase20.WindowsForm2
{
  partial class frmTest2
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.btnBoton3 = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(155, 100);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(75, 23);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "button1";
            this.btnBoton1.UseVisualStyleBackColor = true;
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(304, 100);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(75, 23);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "button2";
            this.btnBoton2.UseVisualStyleBackColor = true;
            // 
            // btnBoton3
            // 
            this.btnBoton3.Location = new System.Drawing.Point(470, 100);
            this.btnBoton3.Name = "btnBoton3";
            this.btnBoton3.Size = new System.Drawing.Size(75, 23);
            this.btnBoton3.TabIndex = 2;
            this.btnBoton3.Text = "button3";
            this.btnBoton3.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(304, 209);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            // 
            // frmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnBoton3);
            this.Controls.Add(this.btnBoton2);
            this.Controls.Add(this.btnBoton1);
            this.Name = "frmTest2";
            this.Text = "frmTest2";
            this.Load += new System.EventHandler(this.Inicializar);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnBoton1;
    private System.Windows.Forms.Button btnBoton2;
    private System.Windows.Forms.Button btnBoton3;
    private System.Windows.Forms.Button btnOperar;
  }
}

