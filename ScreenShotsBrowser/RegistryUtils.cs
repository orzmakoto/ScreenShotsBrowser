using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenShotsBrowser
{
	public static class RegistryUtils
	{
		const string FEATURE_BROWSER_EMULATION = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
		static Microsoft.Win32.RegistryKey regkey = null;

		public static bool Set_FEATURE_BROWSER_EMULATION(int value)
		{
			try
			{
				if(regkey == null)
				{
					regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION);
				}
				regkey.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", value, Microsoft.Win32.RegistryValueKind.DWord);
				regkey.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".vshost.exe", value, Microsoft.Win32.RegistryValueKind.DWord);
				return true;
			}
			catch
			{
				return false;
			}
		}
		public static int Get_FEATURE_BROWSER_EMULATION()
		{
			try
			{
				if(regkey == null)
				{
					regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION);
				}
				return (int)regkey.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe");
			}
			catch
			{
				return 7000;
			}
		}
	}
}
