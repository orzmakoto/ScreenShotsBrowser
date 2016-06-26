using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotsBrowser
{
	public class IeVersionSelector : ComboBox
	{
		public IeVersionSelector()
		{
			foreach(var kv in name2Ver)
			{
				base.Items.Add(kv.Key);
			}
			base.SelectedIndex = 0;

			var current = RegistryUtils.Get_FEATURE_BROWSER_EMULATION();

			if(name2Ver.Any(i => i.Value == current))
			{
				var currentText = name2Ver.Where(i => i.Value == current).First().Key;
				base.SelectedItem = currentText;
			}

			base.SelectedIndexChanged += OnSelectedIndexChanged;
		}
		private Dictionary<string, int> name2Ver = new Dictionary<string, int>()
		{
			{ "IE11 Edge",11001},
			{ "IE11",11000},
			{ "IE10 Stan",10001},
			{ "IE10",10000},
			{ "IE9 Stan",9999},
			{ "IE9",9000},
			{ "IE8 Stan",8888},
			{ "IE8",8000},
			{ "IE7",7000}
		};

		protected void OnSelectedIndexChanged(object sender, EventArgs e)
		{
			RegistryUtils.Set_FEATURE_BROWSER_EMULATION(name2Ver[base.SelectedItem as string]);

			var result = MessageBox.Show($"ブラウザバージョンを{base.SelectedText}に変更しました。\r\n次回起動から有効になります", "ブラウザバージョン変更", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
