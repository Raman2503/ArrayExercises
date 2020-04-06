namespace Sierpinski
{
	partial class Form
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
			this.Draw_Button = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.depthTextBoxLabel = new System.Windows.Forms.TextBox();
			this.depthTextbox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// Draw_Button
			// 
			this.Draw_Button.Location = new System.Drawing.Point(12, 401);
			this.Draw_Button.Name = "Draw_Button";
			this.Draw_Button.Size = new System.Drawing.Size(105, 48);
			this.Draw_Button.TabIndex = 0;
			this.Draw_Button.Text = "Draw";
			this.Draw_Button.UseVisualStyleBackColor = true;
			this.Draw_Button.Click += new System.EventHandler(this.Draw_Button_Click_1);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(74, 36);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(636, 323);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// depthTextBoxLabel
			// 
			this.depthTextBoxLabel.Location = new System.Drawing.Point(151, 408);
			this.depthTextBoxLabel.Name = "depthTextBoxLabel";
			this.depthTextBoxLabel.Size = new System.Drawing.Size(91, 20);
			this.depthTextBoxLabel.TabIndex = 2;
			this.depthTextBoxLabel.Text = "Selected depth:";
			// 
			// depthTextbox
			// 
			this.depthTextbox.Location = new System.Drawing.Point(248, 408);
			this.depthTextbox.Name = "depthTextbox";
			this.depthTextbox.Size = new System.Drawing.Size(39, 20);
			this.depthTextbox.TabIndex = 3;
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.depthTextbox);
			this.Controls.Add(this.depthTextBoxLabel);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.Draw_Button);
			this.Name = "Form";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Draw_Button;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TextBox depthTextbox;
		private System.Windows.Forms.TextBox depthTextBoxLabel;
	}
}

