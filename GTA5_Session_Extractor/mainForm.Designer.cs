
namespace GTA5_Session_Extractor
{
	partial class mainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.outputTextbox = new System.Windows.Forms.RichTextBox();
			this.copySessionBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// outputTextbox
			// 
			this.outputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.outputTextbox.Location = new System.Drawing.Point(12, 54);
			this.outputTextbox.Name = "outputTextbox";
			this.outputTextbox.ReadOnly = true;
			this.outputTextbox.Size = new System.Drawing.Size(297, 241);
			this.outputTextbox.TabIndex = 6;
			this.outputTextbox.Text = "";
			this.outputTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.outputTextbox_LinkClicked);
			// 
			// copySessionBtn
			// 
			this.copySessionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copySessionBtn.Location = new System.Drawing.Point(12, 12);
			this.copySessionBtn.Name = "copySessionBtn";
			this.copySessionBtn.Size = new System.Drawing.Size(297, 23);
			this.copySessionBtn.TabIndex = 7;
			this.copySessionBtn.Text = "Copy session details to clipboard";
			this.copySessionBtn.UseVisualStyleBackColor = true;
			this.copySessionBtn.Click += new System.EventHandler(this.copySessionBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Output";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 307);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.copySessionBtn);
			this.Controls.Add(this.outputTextbox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mainForm";
			this.Text = "GTA 5 Session Extractor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox outputTextbox;
		private System.Windows.Forms.Button copySessionBtn;
		private System.Windows.Forms.Label label1;
	}
}

