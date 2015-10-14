using System.Collections.Generic;

namespace Yatzee_eigen_versie
{
  partial class Yatzee
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
    /// 


    private void InitializeComponent()
    {
      this.WerperAll = new System.Windows.Forms.Button();
      this.score = new System.Windows.Forms.Label();
      this.worpen = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.high = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // WerperAll
      // 
      this.WerperAll.Location = new System.Drawing.Point(25, 335);
      this.WerperAll.Name = "WerperAll";
      this.WerperAll.Size = new System.Drawing.Size(151, 41);
      this.WerperAll.TabIndex = 0;
      this.WerperAll.Text = "Werpen";
      this.WerperAll.UseVisualStyleBackColor = true;
      this.WerperAll.Click += new System.EventHandler(this.WerperAll_Click);
      // 
      // score
      // 
      this.score.AutoSize = true;
      this.score.Location = new System.Drawing.Point(88, 23);
      this.score.Name = "score";
      this.score.Size = new System.Drawing.Size(13, 13);
      this.score.TabIndex = 1;
      this.score.Text = "0";
      // 
      // worpen
      // 
      this.worpen.AutoSize = true;
      this.worpen.Location = new System.Drawing.Point(356, 23);
      this.worpen.Name = "worpen";
      this.worpen.Size = new System.Drawing.Size(13, 13);
      this.worpen.TabIndex = 2;
      this.worpen.Text = "0";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(296, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Worpen : ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(38, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Score : ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(38, 49);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "High Score : ";
      // 
      // high
      // 
      this.high.AutoSize = true;
      this.high.Location = new System.Drawing.Point(116, 49);
      this.high.Name = "high";
      this.high.Size = new System.Drawing.Size(13, 13);
      this.high.TabIndex = 6;
      this.high.Text = "0";
      // 
      // Yatzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(542, 410);
      this.Controls.Add(this.high);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.worpen);
      this.Controls.Add(this.score);
      this.Controls.Add(this.WerperAll);
      this.Name = "Yatzee";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Yatzee_Load);
      this.Click += new System.EventHandler(this.Yatzee_Click);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button WerperAll;
    private System.Windows.Forms.Label score;
    private System.Windows.Forms.Label worpen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label high;



  }
}

