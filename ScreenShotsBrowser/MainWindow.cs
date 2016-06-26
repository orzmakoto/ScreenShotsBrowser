using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ScreenShotsBrowser.Browser;
using ScreenShotsBrowser.Properties;
using XToolKit.Form;

namespace ScreenShotsBrowser
{
	public partial class MainWindow : XMainForm
	{
		public MainWindow()
		{
			InitializeComponent();
			cmb_addInfoPosition.SelectedIndex = 0;

			ChageBrowser(BrowserType.Trident);
		}

		IBrowser browser;
		PointerForm pf = null;

		private const string FormValueKey_SliderLocation = "FormValueKey_SliderLocation";
		private const string FormValueKey_UrlList = "FormValueKey_UrlList";

		//public decimal SchottCount { get; set; }
		//public decimal SchottTotalSize { get; set; }

		private void ChageBrowser(BrowserType browserType)
		{
			panel_Browser.Controls.Clear();
			Control browserControl = null;
			switch (browserType)
			{
				case BrowserType.Trident:
					{
						browserControl = new TridentBrowser();
						image_Icon.Image = Resources.ie;
					} break;
				//case BrowserType.Webkit:
				//	{
				//		browserControl = new WebkitBrowser();
				//		image_Icon.Image = Resources.Webkit;
				//	} break;
			}

			browserControl.Dock = DockStyle.Fill;
			panel_Browser.Controls.Add(browserControl);
			browser = browserControl as IBrowser;

			browser.ScrollBarsEnabled = true;
			browser.Navigating += WebBrowserNavigating;
			browser.Navigated += WebBrowserNavigated;
			browser.Navigate(new Uri("http://yahoo.co.jp/"));
			webBrowser_SizeChanged(null, null);
		}


		private void MainWindow_Load(object sender, EventArgs e)
		{
			panel2.Enabled = false;
			var data = FormManager.Instance.GetUserValue<string>(FormValueKey_UrlList, null);
			if(data != null)
			{
				DataHouse.InputUrls = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(data);
				DataHouse.InputUrls.ForEach(i =>
				{
					cmd_Url.Items.Add(i);
				});
			}
			data = FormManager.Instance.GetUserValue<string>(FormValueKey_SliderLocation, null);
			if(data != null)
			{
				var temp = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SliderLocationSetting>>(data);
				foreach(var kv in temp)
				{
					AddSliderSettingContextMenu(kv);
				}
			}
			cmd_Pointer.Items.Add("非表示");
			pf = new PointerForm();
			{

				pf.Images.Keys.ToList().ForEach(key =>
				{
					cmd_Pointer.Items.Add(key);
				});
				cmd_Pointer.SelectedIndex = 0;
				cmd_Pointer.SelectedIndexChanged += (o, e2) =>
				{

					var type = cmd_Pointer.Text;

					if(type == "非表示")
					{
						pf.Hide();
					}
					else
					{
						pf.Hide();
						pf.Show();
						if(pf.Tag == null)
						{
							pf.Location = (browser as Control).PointToScreen(new Point());
							pf.Tag = "";
						}
						pf.ChangeImage(type);
					}
				};
			}

		}

		#region GetImage

		private Bitmap SetImageInfo(Bitmap returnImage)
		{
			//枠線追加
			if (cb_ImageFrame.Checked == true)
			{
				Bitmap newImage = new Bitmap(returnImage.Width + 2, returnImage.Height + 2, PixelFormat.Format32bppArgb);
				Graphics imageGraphics = Graphics.FromImage(newImage);

				imageGraphics.FillRectangle(Brushes.Gray, new Rectangle(0, 0, newImage.Width, newImage.Height));
				imageGraphics.DrawImage(returnImage, 1, 1, returnImage.Width, returnImage.Height);

				returnImage = newImage;
			}


			if (cmb_addInfoPosition.Text != "非表示")
			{
				var rec = new Rectangle(0, 0, returnImage.Width, returnImage.Height);
				Bitmap newImage = new Bitmap(rec.Width, rec.Height + 20, PixelFormat.Format32bppArgb);
				Graphics imageGraphics = Graphics.FromImage(newImage);

				imageGraphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, newImage.Width, newImage.Height));

				int bodyStart = 0;
				int infoStart = 0;
				if (cmb_addInfoPosition.Text == "上")
				{
					infoStart = 0;
					bodyStart = 20;
				}
				else if (cmb_addInfoPosition.Text == "下")
				{
					infoStart = newImage.Height - 20;
					bodyStart = 0;
				}
				imageGraphics.DrawImage(returnImage, 0, bodyStart, rec.Width, rec.Height);

				var textList = new List<string>();

				if (cb_Url.Checked == true)
				{
					var urlString = browser.Url.AbsoluteUri;
					if (browser.Url.Query.Length != 0)
					{
						urlString = urlString.Replace(browser.Url.Query, "");
					}
					textList.Add(string.Format("URL:{0}", urlString));
				}
				if (cb_Version.Checked == true)
				{
					textList.Add(string.Format("Version:{0}", browser.Version));
				}
				if (cb_AddSize.Checked == true)
				{
					textList.Add(string.Format("Size:{0}*{1}", browser.ClientSize.Width, browser.ClientSize.Height));
				}
				if (cb_Author.Checked == true)
				{
					textList.Add(string.Format("Author:{0}", tb_Author.Text));
				}
				if (cb_Comment.Checked == true)
				{
					textList.Add(string.Format("Remark:{0}", tb_Comment.Text));
				}
				if (textList.Count != 0)
				{
					Font fnt = new Font("MS UI Gothic", 9);
					imageGraphics.DrawString(string.Join(" ", textList), fnt, Brushes.White, 3, infoStart + 4);
				}


				if (cb_AddDateTime.Checked == true)
				{
					Font fnt = new Font("MS UI Gothic", 9);
					imageGraphics.DrawString(string.Format("Time:{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now), fnt, Brushes.White, rec.Width - 135, infoStart + 4);
				}
				returnImage = newImage;
			}
			return returnImage;
		}
		private Bitmap GetImage()
		{
			//返却イメージ
			Bitmap returnImage = null;
			//ブラウザウィンドサイズ
			Rectangle browserRec = new Rectangle(0, 0,
				slider_Horizontally.RangeWidth == 0 ? browser.ClientSize.Width : slider_Horizontally.RangeWidth,
				slider_Vertically.RangeHeight == 0 ? browser.ClientSize.Height : slider_Vertically.RangeHeight);//webBrowser.Bounds;

			//現在のイメージ取得
			{
				Bitmap screenImage = new Bitmap(browserRec.Width, browserRec.Height, PixelFormat.Format32bppArgb);

				Point p = browser.PointToScreen(new Point(0, 0));
				Graphics.FromImage(screenImage).CopyFromScreen(
					p.X + slider_Horizontally.StartLeft,
					p.Y + slider_Vertically.StartTop,
					0, 0,
					browserRec.Size,
					CopyPixelOperation.SourceCopy);

				returnImage = screenImage;
			}
			return SetImageInfo(returnImage);
		}

		#endregion //GetImage

		#region webBrowser

		private void webBrowser_SizeChanged(object sender, EventArgs e)
		{
			toolStrip_WindowSize.Text = string.Format("{0} * {1}", browser.Size.Width, browser.Size.Height);
		}

		private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			cmd_Url.Text = browser.Url.ToString();

			Cursor.Current = Cursors.Default;
		}
		private void WebBrowserNavigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
		}

		private void bt_Navigated_Click(object sender, EventArgs e)
		{
			var oldUrl = browser.Url.ToString();
			try
			{
				browser.Url = new Uri(cmd_Url.Text);
				DataHouse.InputUrls.RemoveAll(s =>
					{
						if (s.ToLower() == cmd_Url.Text.ToLower())
						{
							return true;
						}
						return false;
					});
				DataHouse.InputUrls.Insert(0, cmd_Url.Text);
				//直近10件のみ保存
				if (DataHouse.InputUrls.Count > 11)
				{
					DataHouse.InputUrls = DataHouse.InputUrls.GetRange(0, 10);
				}
				cmd_Url.Items.Clear();
				foreach (var item in DataHouse.InputUrls)
				{
					cmd_Url.Items.Add(item);
				}
			}
			catch
			{
				browser.Url = new Uri(oldUrl);
			}
		}

		private void bt_BrowserBack_Click(object sender, EventArgs e)
		{
			browser.GoBack();
		}

		private void bt_BrowserNext_Click(object sender, EventArgs e)
		{
			browser.GoForward();
		}
		private void tb_NavigatedUrl_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				bt_Navigated_Click(sender, e);
			}
		}

		#endregion //webBrowser

		private void bt_WebScrn_Click(object sender, EventArgs e)
		{
			var image = GetImage();
			{
				Clipboard.SetImage(GetImage());
				imageCacheViewer1.Add(image);
			}
		}

		private void bt_WebScrnAll_Click(object sender, EventArgs e)
		{
			if (browser is WebBrowser)
			{
				var image = SetImageInfo((browser as WebBrowser).GetCapture());
				{
					Clipboard.SetImage(image);
					imageCacheViewer1.Add(image);
				}
			}
		}


		private void cmb_addInfoPosition_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_addInfoPosition.SelectedIndex != 0)
			{
				panel2.Enabled = true;
			}
			else
			{
				panel2.Enabled = false;
			}
		}


		private void cb_Slider_CheckedChanged(object sender, EventArgs e)
		{
			slider_Horizontally.Visible = cb_Slider.Checked;
			slider_Vertically.Visible = cb_Slider.Checked;
		}

		#region SliderContextMenu

		private void AddSliderSettingContextMenu(SliderLocationSetting setting)
		{
			DataHouse.SliderLocation.Add(setting.Key, setting);

			var newItem = new ToolStripMenuItem();
			newItem.Text = string.Format("{0}({1:HH:mm})", setting.Text, DateTime.Now);
			newItem.Tag = setting.Key;
			var 復元 = new ToolStripMenuItem() { Text = "復元", Tag = setting.Key };
			復元.Click += (s, ea) =>
			{
				var key = (s as ToolStripMenuItem).Tag as string;
				var csetting = DataHouse.SliderLocation[key];
				slider_Horizontally.SetSliderLocation(csetting.HorizontallyStart.ToPoint(), csetting.HorizontallyEnd.ToPoint());
				slider_Vertically.SetSliderLocation(csetting.VerticallyStart.ToPoint(), csetting.VerticallyEnd.ToPoint());
			};
			var 上書き = new ToolStripMenuItem() { Text = "ここに上書き", Tag = setting.Key };
			上書き.Click += (s, ea) =>
			{
				var key = (s as ToolStripMenuItem).Tag as string;
				var setting2 = new SliderLocationSetting();
				slider_Horizontally.GetSliderLocation(out setting2.HorizontallyStart, out setting2.HorizontallyEnd);
				slider_Vertically.GetSliderLocation(out setting2.VerticallyStart, out setting2.VerticallyEnd);
				DataHouse.SliderLocation[key] = setting2;
			};
			var 削除 = new ToolStripMenuItem() { Text = "削除", Tag = setting.Key };
			削除.Click += (s, ea) =>
			{
				var key = (s as ToolStripMenuItem).Tag as string;
				var count = slider_contextMenuStrip.Items.Count;
				for (int index = 0; index < count; index++)
				{
					var item = slider_contextMenuStrip.Items[index] as ToolStripMenuItem;
					if ((item.Tag is string) && (item.Tag as string) == key)
					{
						DataHouse.SliderLocation.Remove(key);
						slider_contextMenuStrip.Items.RemoveAt(index);
						break;
					}
				}
			};

			newItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				復元,
				上書き,
				new ToolStripSeparator(),
				削除
			});
			slider_contextMenuStrip.Items.Insert(slider_contextMenuStrip.Items.Count - 2, newItem);
		}

		private void 今の位置を保存ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var inputForm = new InputSaveSliderName();
			if (inputForm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel
				|| string.IsNullOrEmpty(inputForm.InputText) == true)
			{
				return;
			}
			var setting = new SliderLocationSetting();
			setting.Key = inputForm.InputText + DateTime.Now.Ticks;
			setting.Text = inputForm.InputText;
			slider_Horizontally.GetSliderLocation(out setting.HorizontallyStart, out setting.HorizontallyEnd);
			slider_Vertically.GetSliderLocation(out setting.VerticallyStart, out setting.VerticallyEnd);

			AddSliderSettingContextMenu(setting);
		}

		#endregion SliderContextMenu

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				FormManager.Instance.SaveUserValue(FormValueKey_UrlList, Newtonsoft.Json.JsonConvert.SerializeObject(DataHouse.InputUrls));
				FormManager.Instance.SaveUserValue(FormValueKey_SliderLocation, Newtonsoft.Json.JsonConvert.SerializeObject(DataHouse.SliderLocation.Values.ToList()));
			}
			catch { }
		}

		private void cmd_Url_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_Navigated_Click(bt_Navigated, e);
			}
		}

		private void MainWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.S)
			{
				bt_WebScrn_Click(sender, e);
			}
		}

		private void panel_Browser_SizeChanged(object sender, EventArgs e)
		{
			slider_Horizontally.SetTargetControlSize(panel_Browser.Size);
			slider_Vertically.SetTargetControlSize(panel_Browser.Size);
		}
	}

	public static class DataHouse
	{
		public static List<string> InputUrls = new List<string>();
		public static Dictionary<string, SliderLocationSetting> SliderLocation = new Dictionary<string, SliderLocationSetting>();
	}

	[Serializable]
	public class SliderLocationSetting
	{
		public string Key;
		public string Text;
		public SimplePoint HorizontallyStart;
		public SimplePoint HorizontallyEnd;

		public SimplePoint VerticallyStart;
		public SimplePoint VerticallyEnd;
	}

	public enum SliderPosition
	{
		Left, Right, Top, Bottom
	}
	public class SimplePoint
	{
		public SimplePoint() { }
		public SimplePoint(Point point)
		{
			this.X = point.X;
			this.Y = point.Y;
		}
		public int X { get; set; }
		public int Y { get; set; }

		public Point ToPoint()
		{
			return new Point(this.X, this.Y);
		}
	}
	public static class ExUtil
	{
		public static SimplePoint ToSimplePoint(this Point source)
		{
			return new SimplePoint(source);
		}
	}
}
