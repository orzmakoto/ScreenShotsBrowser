namespace ScreenShotsBrowser
{
	partial class ImageCacheViewer
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.取得ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.la_Count = new System.Windows.Forms.Label();
			this.la_Next = new System.Windows.Forms.Label();
			this.la_Back = new System.Windows.Forms.Label();
			this.la_delete = new System.Windows.Forms.Label();
			this.pict_Viewer = new System.Windows.Forms.PictureBox();
			this.cb_AutoSave = new XToolKit.Form.XCheckBox();
			this.bt_FolderSelect = new XToolKit.Form.XFolderSelectButton();
			this.bt_SaveAll = new XToolKit.Form.XFolderSelectButton();
			this.保存StripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pict_Viewer)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取得ToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.保存StripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
			// 
			// 取得ToolStripMenuItem
			// 
			this.取得ToolStripMenuItem.Name = "取得ToolStripMenuItem";
			this.取得ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.取得ToolStripMenuItem.Text = "コピー";
			this.取得ToolStripMenuItem.Click += new System.EventHandler(this.取得ToolStripMenuItem_Click);
			// 
			// 表示ToolStripMenuItem
			// 
			this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
			this.表示ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.表示ToolStripMenuItem.Text = "表示";
			this.表示ToolStripMenuItem.Click += new System.EventHandler(this.表示ToolStripMenuItem_Click);
			// 
			// la_Count
			// 
			this.la_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.la_Count.AutoSize = true;
			this.la_Count.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.la_Count.Location = new System.Drawing.Point(130, 150);
			this.la_Count.Name = "la_Count";
			this.la_Count.Size = new System.Drawing.Size(32, 16);
			this.la_Count.TabIndex = 14;
			this.la_Count.Text = "0/0";
			// 
			// la_Next
			// 
			this.la_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.la_Next.AutoSize = true;
			this.la_Next.Cursor = System.Windows.Forms.Cursors.Hand;
			this.la_Next.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.la_Next.Location = new System.Drawing.Point(107, 150);
			this.la_Next.Name = "la_Next";
			this.la_Next.Size = new System.Drawing.Size(17, 16);
			this.la_Next.TabIndex = 13;
			this.la_Next.Text = ">";
			this.la_Next.Click += new System.EventHandler(this.la_Next_Click);
			// 
			// la_Back
			// 
			this.la_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.la_Back.AutoSize = true;
			this.la_Back.Cursor = System.Windows.Forms.Cursors.Hand;
			this.la_Back.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.la_Back.Location = new System.Drawing.Point(84, 150);
			this.la_Back.Name = "la_Back";
			this.la_Back.Size = new System.Drawing.Size(17, 16);
			this.la_Back.TabIndex = 12;
			this.la_Back.Text = "<";
			this.la_Back.Click += new System.EventHandler(this.la_Back_Click);
			// 
			// la_delete
			// 
			this.la_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.la_delete.AutoSize = true;
			this.la_delete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.la_delete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.la_delete.Location = new System.Drawing.Point(3, 150);
			this.la_delete.Name = "la_delete";
			this.la_delete.Size = new System.Drawing.Size(25, 16);
			this.la_delete.TabIndex = 15;
			this.la_delete.Text = "✕";
			this.la_delete.Click += new System.EventHandler(this.la_delete_Click);
			// 
			// pict_Viewer
			// 
			this.pict_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pict_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pict_Viewer.ContextMenuStrip = this.contextMenuStrip1;
			this.pict_Viewer.Location = new System.Drawing.Point(0, 0);
			this.pict_Viewer.Name = "pict_Viewer";
			this.pict_Viewer.Size = new System.Drawing.Size(178, 147);
			this.pict_Viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pict_Viewer.TabIndex = 11;
			this.pict_Viewer.TabStop = false;
			// 
			// cb_AutoSave
			// 
			this.cb_AutoSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_AutoSave.AutoSize = true;
			this.cb_AutoSave.Location = new System.Drawing.Point(3, 173);
			this.cb_AutoSave.Name = "cb_AutoSave";
			this.cb_AutoSave.SavedValue = false;
			this.cb_AutoSave.Size = new System.Drawing.Size(72, 16);
			this.cb_AutoSave.TabIndex = 16;
			this.cb_AutoSave.Text = "自動保存";
			this.cb_AutoSave.UseVisualStyleBackColor = true;
			this.cb_AutoSave.CheckedChanged += new System.EventHandler(this.cb_AutoSave_CheckedChanged);
			// 
			// bt_FolderSelect
			// 
			this.bt_FolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_FolderSelect.Location = new System.Drawing.Point(82, 169);
			this.bt_FolderSelect.Name = "bt_FolderSelect";
			this.bt_FolderSelect.SelectedPath = "";
			this.bt_FolderSelect.Size = new System.Drawing.Size(93, 23);
			this.bt_FolderSelect.TabIndex = 17;
			this.bt_FolderSelect.Text = "保存先...";
			this.bt_FolderSelect.UseVisualStyleBackColor = true;
			this.bt_FolderSelect.FolderSelect += new XToolKit.Form.FolderSelectEventHandler(this.bt_FolderSelect_FolderSelect);
			// 
			// bt_SaveAll
			// 
			this.bt_SaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bt_SaveAll.Location = new System.Drawing.Point(3, 195);
			this.bt_SaveAll.Name = "bt_SaveAll";
			this.bt_SaveAll.SelectedPath = "";
			this.bt_SaveAll.Size = new System.Drawing.Size(172, 23);
			this.bt_SaveAll.TabIndex = 18;
			this.bt_SaveAll.Text = "全て保存";
			this.bt_SaveAll.UseVisualStyleBackColor = true;
			this.bt_SaveAll.FolderSelect += new XToolKit.Form.FolderSelectEventHandler(this.bt_SaveAll_FolderSelect);
			// 
			// 保存StripMenuItem1
			// 
			this.保存StripMenuItem1.Name = "保存StripMenuItem1";
			this.保存StripMenuItem1.Size = new System.Drawing.Size(161, 22);
			this.保存StripMenuItem1.Text = "名前を付けて保存";
			this.保存StripMenuItem1.Click += new System.EventHandler(this.保存StripMenuItem1_Click);
			// 
			// ImageCacheViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bt_SaveAll);
			this.Controls.Add(this.bt_FolderSelect);
			this.Controls.Add(this.cb_AutoSave);
			this.Controls.Add(this.la_delete);
			this.Controls.Add(this.pict_Viewer);
			this.Controls.Add(this.la_Count);
			this.Controls.Add(this.la_Next);
			this.Controls.Add(this.la_Back);
			this.Name = "ImageCacheViewer";
			this.Size = new System.Drawing.Size(178, 221);
			this.Load += new System.EventHandler(this.ImageCacheViewer_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pict_Viewer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label la_Count;
		private System.Windows.Forms.Label la_Next;
		private System.Windows.Forms.Label la_Back;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
		private System.Windows.Forms.Label la_delete;
		private System.Windows.Forms.ToolStripMenuItem 取得ToolStripMenuItem;
		private System.Windows.Forms.PictureBox pict_Viewer;
		private XToolKit.Form.XCheckBox cb_AutoSave;
		private XToolKit.Form.XFolderSelectButton bt_FolderSelect;
		private XToolKit.Form.XFolderSelectButton bt_SaveAll;
		private System.Windows.Forms.ToolStripMenuItem 保存StripMenuItem1;
	}
}
