using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotsBrowser
{
	public partial class ImageEditer : Form
	{
		public ImageEditer(Image image)
		{
			InitializeComponent();
			Image = image;
			pictureBox1.Image = Image;
		}

		public Image Image { get; private set; }
	}
}
