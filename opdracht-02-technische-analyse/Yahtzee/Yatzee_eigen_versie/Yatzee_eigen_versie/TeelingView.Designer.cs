namespace Yatzee_eigen_versie
{
  partial class TeelingView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.teerling = new System.Windows.Forms.Label();
      this.werp = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // teerling
      // 
      this.teerling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.teerling.Location = new System.Drawing.Point(33, 116);
      this.teerling.Name = "teerling";
      this.teerling.Size = new System.Drawing.Size(116, 106);
      this.teerling.TabIndex = 0;
      this.teerling.Text = "Teerling";
      this.teerling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.teerling.Click += new System.EventHandler(this.teerling_Click);
      // 
      // werp
      // 
      this.werp.Location = new System.Drawing.Point(33, 245);
      this.werp.Name = "werp";
      this.werp.Size = new System.Drawing.Size(116, 23);
      this.werp.TabIndex = 1;
      this.werp.Text = "Werp";
      this.werp.UseVisualStyleBackColor = true;
      this.werp.Visible = false;
      this.werp.Click += new System.EventHandler(this.werp_Click);
      // 
      // TeelingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.werp);
      this.Controls.Add(this.teerling);
      this.Name = "TeelingView";
      this.Size = new System.Drawing.Size(208, 350);
      this.Load += new System.EventHandler(this.TeelingView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label teerling;
    private System.Windows.Forms.Button werp;
  }
}
