using System.Collections.Generic;

namespace Yahtzee
{
	partial class TeerlingView
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
			this.TeerlingLabel = new System.Windows.Forms.Label();
			this.TeerlingWerpen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TeerlingLabel
			// 
			this.TeerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TeerlingLabel.Location = new System.Drawing.Point(3, 23);
			this.TeerlingLabel.Name = "TeerlingLabel";
			this.TeerlingLabel.Size = new System.Drawing.Size(128, 128);
			this.TeerlingLabel.TabIndex = 2;
			this.TeerlingLabel.Text = "Teerling";
			this.TeerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TeerlingLabel.Click += new System.EventHandler(this.TeerlingLabel_Click);
			// 
			// TeerlingWerpen
			// 
			this.TeerlingWerpen.Location = new System.Drawing.Point(3, 154);
			this.TeerlingWerpen.Name = "TeerlingWerpen";
			this.TeerlingWerpen.Size = new System.Drawing.Size(128, 35);
			this.TeerlingWerpen.TabIndex = 3;
			this.TeerlingWerpen.Text = "Werp";
			this.TeerlingWerpen.UseVisualStyleBackColor = true;
			this.TeerlingWerpen.Click += new System.EventHandler(this.TeerlingWerpen_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "TeerlingIndex";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.TeerlingLabel);
			this.flowLayoutPanel1.Controls.Add(this.TeerlingWerpen);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 196);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// TeerlingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "TeerlingView";
			this.Size = new System.Drawing.Size(134, 196);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TeerlingLabel;
		private System.Windows.Forms.Button TeerlingWerpen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
