using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotsBrowser
{
	public class GuideLineForm : Form
	{
		public GuideLineForm()
		{
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.BackColor = Color.Red;
			this.TopMost = true;
			this.ShowInTaskbar = false;
		}

		private Size baseSize;

		protected override void OnShown(EventArgs e)
		{
			base.Size = baseSize;
			base.OnShown(e);
		}

		public void ShowHorizontally(int height = 300)
		{
			baseSize = new Size(1, height);
			base.Show();
		}
		public void ShowVertically(int width = 300)
		{
			baseSize = new Size(width, 1);
			base.Show();
		}
	}
}
