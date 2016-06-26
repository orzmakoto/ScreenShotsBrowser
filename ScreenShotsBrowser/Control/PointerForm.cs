using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenShotsBrowser.Properties;

namespace ScreenShotsBrowser
{
	public partial class PointerForm : Form
	{
		public PointerForm()
		{
			InitializeComponent();
			this.TopMost = true;
			this.ShowInTaskbar = false;

			LoadImages();
		}

		public Dictionary<string, Bitmap> Images = new Dictionary<string, Bitmap>();

		public void LoadImages()
		{
			var pointerForm = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ScreenShotsBrowser\PointerForm");
			if(Directory.Exists(pointerForm) == false)
			{
				Directory.CreateDirectory(pointerForm);
			}
			var files = Directory.GetFiles(pointerForm, "*.png", SearchOption.TopDirectoryOnly);

			//Images.Add("非表示", null);
			foreach (var file in files)
			{
				var image = new Bitmap(file);
				Images.Add(Path.GetFileNameWithoutExtension(file), image);
			}
		}

		public void ChangeImage(string key)
		{
			if (Images.ContainsKey(key) == true)
			{
				Bitmap image = Images[key];
				this.FormBorderStyle = FormBorderStyle.None;
				this.TransparencyKey = Color.Red;
				this.BackColor = Color.Red;
				image.MakeTransparent(Color.Red);
				this.Size = image.Size;
				this.BackgroundImage = image;
			}
		}

		protected override void WndProc(ref Message m)
		{
			// Form のドラッグ移動 処理
			base.WndProc(ref m);
			if ((m.Msg == 0x84) && (m.Result == (IntPtr)1)) m.Result = (IntPtr)2;
		}

	}

	public enum PointerFormType
	{
		None,
		Hand_S,
		Hand_M,
		Hand_L,
		Hand2_S,
		Hand2_M,
		Hand2_L
	}
}
