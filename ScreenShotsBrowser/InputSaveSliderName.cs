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
	public partial class InputSaveSliderName : Form
	{
		public InputSaveSliderName()
		{
			InitializeComponent();
		}

		public string InputText
		{
			get
			{
				return this.tb_name.Text;
			}
		}

		private void bt_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void bt_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
	}
}
