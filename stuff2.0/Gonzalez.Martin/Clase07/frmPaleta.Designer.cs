namespace Clase07
{
  partial class frmPaleta
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
            this.BtnMas = new System.Windows.Forms.Button();
            this.LstLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnMas
            // 
            this.BtnMas.Location = new System.Drawing.Point(354, 258);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(75, 23);
            this.BtnMas.TabIndex = 0;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // LstLista
            // 
            this.LstLista.FormattingEnabled = true;
            this.LstLista.Location = new System.Drawing.Point(60, 2);
            this.LstLista.Name = "LstLista";
            this.LstLista.Size = new System.Drawing.Size(724, 251);
            this.LstLista.TabIndex = 1;
            // 
            // frmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 293);
            this.Controls.Add(this.LstLista);
            this.Controls.Add(this.BtnMas);
            this.Name = "frmPaleta";
            this.Text = "frmPaleta";
            this.Load += new System.EventHandler(this.frmPaleta_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnMas;
    private System.Windows.Forms.ListBox LstLista;
  }
}

