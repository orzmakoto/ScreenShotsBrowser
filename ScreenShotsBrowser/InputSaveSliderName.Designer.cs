namespace ScreenShotsBrowser
{
	partial class InputSaveSliderName
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
			this.tb_name = new System.Windows.Forms.TextBox();
			this.bt_ok = new System.Windows.Forms.Button();
			this.bt_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(12, 12);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(210, 19);
			this.tb_name.TabIndex = 0;
			// 
			// bt_ok
			// 
			this.bt_ok.Location = new System.Drawing.Point(66, 37);
			this.bt_ok.Name = "bt_ok";
			this.bt_ok.Size = new System.Drawing.Size(75, 23);
			this.bt_ok.TabIndex = 1;
			this.bt_ok.Text = "OK";
			this.bt_ok.UseVisualStyleBackColor = true;
			this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
			// 
			// bt_cancel
			// 
			this.bt_cancel.Location = new System.Drawing.Point(147, 37);
			this.bt_cancel.Name = "bt_cancel";
			this.bt_cancel.Size = new System.Drawing.Size(75, 23);
			this.bt_cancel.TabIndex = 2;
			this.bt_cancel.Text = "キャンセル";
			this.bt_cancel.UseVisualStyleBackColor = true;
			this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
			// 
			// InputSaveSliderName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 71);
			this.Controls.Add(this.bt_cancel);
			this.Controls.Add(this.bt_ok);
			this.Controls.Add(this.tb_name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "InputSaveSliderName";
			this.Text = "設定名を入力";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.Button bt_ok;
		private System.Windows.Forms.Button bt_cancel;
	}
}