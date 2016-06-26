using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotsBrowser.Browser
{
	public enum BrowserType
	{
		None = 0,
		Trident,
		Webkit
	}
	public interface IBrowser
	{
		BrowserType BrowserType { get; }
		/// <summary>
		/// 戻る
		/// </summary>
		void GoBack();
		/// <summary>
		/// 次に進む
		/// </summary>
		void GoForward();
		/// <summary>
		/// URL設定
		/// </summary>
		void Navigate(Uri uri);
		/// <summary>
		/// URL
		/// </summary>
		Uri Url { get; set; }

		bool ScrollBarsEnabled { get; set; }

		Size Size { get; set; }
		Size ClientSize { get; set; }
		string Version { get; }
		bool Focus();

		Point PointToScreen(Point point);


		event WebBrowserNavigatedEventHandler Navigated;
		event WebBrowserNavigatingEventHandler Navigating;
	}

	//public class MultiEngineBrowser : Panel
	//{
	//	public MultiEngineBrowser()
	//	{
	//		Navigated += (a, b) => { };
	//		Navigating += (a, b) => { };
	//		ChageBrowser(BrowserType.Trident);
	//	}
	//	IBrowser browser;

	//	public event WebBrowserNavigatedEventHandler Navigated;
	//	public event WebBrowserNavigatingEventHandler Navigating;

	//	public IBrowser Browser
	//	{
	//		get
	//		{
	//			return browser;
	//		}
	//	}


	//	private void ChageBrowser(BrowserType browserType)
	//	{
	//		base.Controls.Clear();
	//		Control browserControl = null;
	//		switch (browserType)
	//		{
	//			case BrowserType.Trident:
	//				{
	//					browserControl = new TridentBrowser();
	//				} break;
	//			case BrowserType.Webkit:
	//				{
	//					browserControl = new WebkitBrowser();
	//				} break;
	//		}

	//		browserControl.Dock = DockStyle.Fill;
	//		base.Controls.Add(browserControl);
	//		browser = browserControl as IBrowser;

	//		browser.ScrollBarsEnabled = true;
	//		browser.Navigating += WebBrowserNavigating;
	//		browser.Navigated += WebBrowserNavigated;
	//		//browser.Navigate(new Uri("http://yahoo.co.jp/"));
	//	}

	//	private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
	//	{
	//		//cmd_Url.Text = browser.Url.ToString();

	//		Cursor.Current = Cursors.Default;
	//		Navigated(sender, e);
	//	}
	//	private void WebBrowserNavigating(object sender, WebBrowserNavigatingEventArgs e)
	//	{
	//		Cursor.Current = Cursors.WaitCursor;
	//		Navigating(sender, e);
	//	}

	//	public void GoBack()
	//	{
	//		browser.GoBack();
	//	}
	//	public void GoForward()
	//	{
	//		browser.GoForward();
	//	}
	//	public void Navigate(string url)
	//	{
	//		browser.Navigate(new Uri(url));
	//	}
	//}

	/*
	 http://amonution.sblo.jp/article/57158400.html
http://www.jaist.ac.jp/~t-koba/cstips.php#geckofxhowto
	 */

	public class GeckoBrowser
	{

	}

}
