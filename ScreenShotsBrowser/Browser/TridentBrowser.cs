using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotsBrowser.Browser
{
	public class TridentBrowser : WebBrowser, IBrowser
	{
		#region IBrowser メンバー

		public BrowserType BrowserType
		{
			get
			{
				return Browser.BrowserType.Trident;
			}
		}

		public new void GoBack()
		{
			base.GoBack();
		}

		public new void GoForward()
		{
			base.GoForward();
		}

		public new void Navigated(Uri uri)
		{
			base.Url = uri;
		}
		public new string Version
		{
			get
			{
				return "IE_" + base.Version.ToString();
			}
		}
		#endregion
	}
}
