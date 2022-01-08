
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.steamRadio = new System.Windows.Forms.RadioButton();
			this.rockstarRadio = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// outputTextbox
			// 
			this.outputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.outputTextbox.Location = new System.Drawing.Point(12, 101);
			this.outputTextbox.Name = "outputTextbox";
			this.outputTextbox.ReadOnly = true;
			this.outputTextbox.Size = new System.Drawing.Size(297, 194);
			this.outputTextbox.TabIndex = 6;
			this.outputTextbox.Text = "";
			this.outputTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.outputTextbox_LinkClicked);
			// 
			// copySessionBtn
			// 
			this.copySessionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copySessionBtn.Location = new System.Drawing.Point(119, 12);
			this.copySessionBtn.Name = "copySessionBtn";
			this.copySessionBtn.Size = new System.Drawing.Size(190, 70);
			this.copySessionBtn.TabIndex = 7;
			this.copySessionBtn.Text = "Copy session details to clipboard";
			this.copySessionBtn.UseVisualStyleBackColor = true;
			this.copySessionBtn.Click += new System.EventHandler(this.copySessionBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Output";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rockstarRadio);
			this.groupBox1.Controls.Add(this.steamRadio);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(101, 70);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game version";
			// 
			// steamRadio
			// 
			this.steamRadio.AutoSize = true;
			this.steamRadio.Checked = true;
			this.steamRadio.Location = new System.Drawing.Point(6, 19);
			this.steamRadio.Name = "steamRadio";
			this.steamRadio.Size = new System.Drawing.Size(55, 17);
			this.steamRadio.TabIndex = 0;
			this.steamRadio.TabStop = true;
			this.steamRadio.Text = "Steam";
			this.steamRadio.UseVisualStyleBackColor = true;
			// 
			// rockstarRadio
			// 
			this.rockstarRadio.AutoSize = true;
			this.rockstarRadio.Location = new System.Drawing.Point(6, 42);
			this.rockstarRadio.Name = "rockstarRadio";
			this.rockstarRadio.Size = new System.Drawing.Size(68, 17);
			this.rockstarRadio.TabIndex = 1;
			this.rockstarRadio.Text = "Rockstar";
			this.rockstarRadio.UseVisualStyleBackColor = true;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 307);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.copySessionBtn);
			this.Controls.Add(this.outputTextbox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mainForm";
			this.Text = "GTA 5 Session Extractor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox outputTextbox;
		private System.Windows.Forms.Button copySessionBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rockstarRadio;
		private System.Windows.Forms.RadioButton steamRadio;
	}
}

