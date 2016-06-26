using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using XToolKit.Form;

namespace ScreenShotsBrowser
{
	public partial class ImageCacheViewer : XUserControl
	{
		public ImageCacheViewer()
		{
			InitializeComponent();
			la_Back.Enabled = false;
			la_Next.Enabled = false;
		}

		List<Bitmap> imageCache = new List<Bitmap>();
		public int SelectedIndex { get; set; }

		private bool AutoSave;
		private string AutoSaveFolderPath;



		public void Add(Bitmap image)
		{
			imageCache.Add(image);
			pict_Viewer.Image = image;
			SelectedIndex = imageCache.Count - 1;
			la_Count.Text = string.Format("{0}/{1}", SelectedIndex + 1, imageCache.Count);

			la_Next.Enabled = true;
			la_Back.Enabled = true;
			if((SelectedIndex - 1) < 0)
			{
				la_Back.Enabled = false;
			}
			if((SelectedIndex + 1) > imageCache.Count - 1)
			{
				la_Next.Enabled = false;
			}

			if(this.AutoSave == true)
			{
				try
				{
					if(Directory.Exists(AutoSaveFolderPath) == false)
					{
						ShowErrorMsg("画像の自動保存に失敗しました。\r\n保存先ディレクトリが指定されていません。");
					}
					else if(Directory.Exists(AutoSaveFolderPath) == false)
					{
						ShowErrorMsg("画像の自動保存に失敗しました。\r\n保存先ディレクトリにアクセス出来ません。");
					}
					else
					{
						image.Save(Path.Combine(AutoSaveFolderPath, string.Format("{0:yyyyMMddHHmmss}.png", DateTime.Now)), ImageFormat.Png);
					}
				}
				catch(Exception e)
				{
					ShowErrorMsg("画像の自動保存に失敗しました。\r\n" + e.ToString());
				}
			}
		}

		private void ImageCacheViewer_Load(object sender, EventArgs e)
		{
			cb_AutoSave_CheckedChanged(sender, e);
		}

		private void la_Back_Click(object sender, EventArgs e)
		{
			la_Next.Enabled = true;
			var newIndex = SelectedIndex - 1;

			SelectedIndex = newIndex;
			pict_Viewer.Image = imageCache[SelectedIndex];
			la_Count.Text = string.Format("{0}/{1}", SelectedIndex + 1, imageCache.Count);

			if((SelectedIndex - 1) < 0)
			{
				la_Back.Enabled = false;
			}
		}

		private void la_Next_Click(object sender, EventArgs e)
		{
			la_Back.Enabled = true;
			var newIndex = SelectedIndex + 1;
			if(imageCache.Count <= newIndex)
			{
				return;
			}

			SelectedIndex = newIndex;
			pict_Viewer.Image = imageCache[SelectedIndex];
			la_Count.Text = string.Format("{0}/{1}", SelectedIndex + 1, imageCache.Count);
			if((SelectedIndex + 1) > imageCache.Count - 1)
			{
				la_Next.Enabled = false;
			}
		}

		private void 取得ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(pict_Viewer.Image);
		}

		private void 表示ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(Directory.Exists(@".temp\") == false)
			{
				Directory.CreateDirectory(@".temp\");
			}
			var file = string.Format(@".temp\{0}.png", pict_Viewer.Image.GetHashCode());
			pict_Viewer.Image.Save(file, ImageFormat.Png);
			Process.Start(file);
		}

		private void la_delete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("全て削除します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				imageCache.Clear();
				pict_Viewer.Image = null;
				SelectedIndex = 0;
				la_Back.Enabled = false;
				la_Next.Enabled = false;
				la_Count.Text = "0/0";
			}
		}

		private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new ImageEditer(pict_Viewer.Image)).Show();
		}

		private void cb_AutoSave_CheckedChanged(object sender, EventArgs e)
		{
			bt_FolderSelect.Enabled = cb_AutoSave.Checked;
			AutoSave = cb_AutoSave.Checked;
		}

		private void bt_FolderSelect_FolderSelect(object sender, string folderPath)
		{
			AutoSaveFolderPath = folderPath;
		}

		private void bt_SaveAll_FolderSelect(object sender, string folderPath)
		{
			int index = 1;
			var fileNamePlefix = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒_{0}");
			foreach(var imgSrc in imageCache)
			{
				Image img = new Bitmap(imgSrc);

				using(img)
				{
					img.Save(Path.Combine(folderPath, string.Format(fileNamePlefix, index)) + ".png", ImageFormat.Png);
				}
				index++;
			}

			var result = MessageBox.Show($"{imageCache.Count}枚の画像を保存しました。\r\n保存先のフォルダを開きますか？", "保存完了", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if(result == DialogResult.Yes)
			{
				Process.Start($@"C:\Windows\explorer.exe", folderPath);
			}
		}

		private void 保存StripMenuItem1_Click(object sender, EventArgs e)
		{
			//SaveFileDialogクラスのインスタンスを作成
			SaveFileDialog sfd = new SaveFileDialog();

			//はじめのファイル名を指定する
			//はじめに「ファイル名」で表示される文字列を指定する
			sfd.FileName = "新しいスクリーンショット.png";
			//はじめに表示されるフォルダを指定する
			sfd.InitialDirectory = @"C:\";
			//[ファイルの種類]に表示される選択肢を指定する
			//指定しない（空の文字列）の時は、現在のディレクトリが表示される
			sfd.Filter = "画像ファイル(*.png)|*.*";
			//[ファイルの種類]ではじめに選択されるものを指定する
			//2番目の「すべてのファイル」が選択されているようにする
			sfd.FilterIndex = 0;
			//タイトルを設定する
			sfd.Title = "保存先のファイルを選択してください";
			//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
			sfd.RestoreDirectory = true;
			//既に存在するファイル名を指定したとき警告する
			//デフォルトでTrueなので指定する必要はない
			sfd.OverwritePrompt = true;
			//存在しないパスが指定されたとき警告を表示する
			//デフォルトでTrueなので指定する必要はない
			sfd.CheckPathExists = true;

			//ダイアログを表示する
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				if(File.Exists(sfd.FileName) == true)
				{
					File.Delete(sfd.FileName);
				}
				pict_Viewer.Image.Save(sfd.FileName, ImageFormat.Png);
			}
		}
	}
}
