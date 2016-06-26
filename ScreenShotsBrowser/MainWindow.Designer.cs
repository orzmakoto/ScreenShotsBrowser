using System.Windows.Forms;
using XToolKit.Form;
namespace ScreenShotsBrowser
{
	partial class MainWindow
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

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.bt_WebScrn = new System.Windows.Forms.Button();
			this.bt_Navigated = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cmd_Url = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cb_Slider = new XToolKit.Form.XCheckBox();
			this.slider_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.今の位置を保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.image_Icon = new System.Windows.Forms.PictureBox();
			this.bt_BrowserNext = new System.Windows.Forms.Button();
			this.bt_BrowserBack = new System.Windows.Forms.Button();
			this.panel_Browser = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.cmd_Pointer = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bt_WebScrnAll = new System.Windows.Forms.Button();
			this.cb_ImageFrame = new XToolKit.Form.XCheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cb_Url = new XToolKit.Form.XCheckBox();
			this.tb_Author = new XToolKit.Form.XTextBox();
			this.cb_Version = new XToolKit.Form.XCheckBox();
			this.cb_AddSize = new XToolKit.Form.XCheckBox();
			this.cb_Author = new XToolKit.Form.XCheckBox();
			this.cb_Comment = new XToolKit.Form.XCheckBox();
			this.tb_Comment = new XToolKit.Form.XTextBox();
			this.cb_AddDateTime = new XToolKit.Form.XCheckBox();
			this.cmb_addInfoPosition = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip_WindowSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.slider_Vertically = new ScreenShotsBrowser.LocationVerticallySlider();
			this.slider_Horizontally = new ScreenShotsBrowser.LocationHorizontallySlider();
			this.ieVersionSelector1 = new ScreenShotsBrowser.IeVersionSelector();
			this.imageCacheViewer1 = new ScreenShotsBrowser.ImageCacheViewer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.slider_contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.image_Icon)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bt_WebScrn
			// 
			this.bt_WebScrn.Location = new System.Drawing.Point(74, 268);
			this.bt_WebScrn.Name = "bt_WebScrn";
			this.bt_WebScrn.Size = new System.Drawing.Size(157, 29);
			this.bt_WebScrn.TabIndex = 1;
			this.bt_WebScrn.Text = "画像取得";
			this.bt_WebScrn.UseVisualStyleBackColor = true;
			this.bt_WebScrn.Click += new System.EventHandler(this.bt_WebScrn_Click);
			// 
			// bt_Navigated
			// 
			this.bt_Navigated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Navigated.Location = new System.Drawing.Point(654, 2);
			this.bt_Navigated.Name = "bt_Navigated";
			this.bt_Navigated.Size = new System.Drawing.Size(75, 27);
			this.bt_Navigated.TabIndex = 2;
			this.bt_Navigated.Text = "読み込み";
			this.bt_Navigated.UseVisualStyleBackColor = true;
			this.bt_Navigated.Click += new System.EventHandler(this.bt_Navigated_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.cmd_Url);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel1.Controls.Add(this.slider_Vertically);
			this.splitContainer1.Panel1.Controls.Add(this.slider_Horizontally);
			this.splitContainer1.Panel1.Controls.Add(this.image_Icon);
			this.splitContainer1.Panel1.Controls.Add(this.bt_BrowserNext);
			this.splitContainer1.Panel1.Controls.Add(this.bt_BrowserBack);
			this.splitContainer1.Panel1.Controls.Add(this.panel_Browser);
			this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
			this.splitContainer1.Panel1.Controls.Add(this.bt_Navigated);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.ieVersionSelector1);
			this.splitContainer1.Panel2.Controls.Add(this.cmd_Pointer);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.imageCacheViewer1);
			this.splitContainer1.Panel2.Controls.Add(this.bt_WebScrnAll);
			this.splitContainer1.Panel2.Controls.Add(this.cb_ImageFrame);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.bt_WebScrn);
			this.splitContainer1.Size = new System.Drawing.Size(970, 692);
			this.splitContainer1.SplitterDistance = 732;
			this.splitContainer1.TabIndex = 3;
			// 
			// cmd_Url
			// 
			this.cmd_Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_Url.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cmd_Url.FormattingEnabled = true;
			this.cmd_Url.Location = new System.Drawing.Point(134, 3);
			this.cmd_Url.Name = "cmd_Url";
			this.cmd_Url.Size = new System.Drawing.Size(519, 25);
			this.cmd_Url.TabIndex = 12;
			this.cmd_Url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_Url_KeyDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.cb_Slider);
			this.panel1.Location = new System.Drawing.Point(0, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(22, 22);
			this.panel1.TabIndex = 11;
			// 
			// cb_Slider
			// 
			this.cb_Slider.AutoSize = true;
			this.cb_Slider.Checked = true;
			this.cb_Slider.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_Slider.Location = new System.Drawing.Point(4, 3);
			this.cb_Slider.Name = "cb_Slider";
			this.cb_Slider.SavedValue = true;
			this.cb_Slider.Size = new System.Drawing.Size(15, 14);
			this.cb_Slider.TabIndex = 10;
			this.cb_Slider.UseVisualStyleBackColor = true;
			this.cb_Slider.CheckedChanged += new System.EventHandler(this.cb_Slider_CheckedChanged);
			// 
			// slider_contextMenuStrip
			// 
			this.slider_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.今の位置を保存ToolStripMenuItem});
			this.slider_contextMenuStrip.Name = "slider_contextMenuStrip";
			this.slider_contextMenuStrip.Size = new System.Drawing.Size(154, 32);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
			// 
			// 今の位置を保存ToolStripMenuItem
			// 
			this.今の位置を保存ToolStripMenuItem.Name = "今の位置を保存ToolStripMenuItem";
			this.今の位置を保存ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.今の位置を保存ToolStripMenuItem.Text = "今の位置を保存";
			this.今の位置を保存ToolStripMenuItem.Click += new System.EventHandler(this.今の位置を保存ToolStripMenuItem_Click);
			// 
			// image_Icon
			// 
			this.image_Icon.Location = new System.Drawing.Point(4, 3);
			this.image_Icon.Name = "image_Icon";
			this.image_Icon.Size = new System.Drawing.Size(27, 25);
			this.image_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.image_Icon.TabIndex = 7;
			this.image_Icon.TabStop = false;
			// 
			// bt_BrowserNext
			// 
			this.bt_BrowserNext.Location = new System.Drawing.Point(92, 2);
			this.bt_BrowserNext.Name = "bt_BrowserNext";
			this.bt_BrowserNext.Size = new System.Drawing.Size(41, 27);
			this.bt_BrowserNext.TabIndex = 6;
			this.bt_BrowserNext.Text = ">";
			this.bt_BrowserNext.UseVisualStyleBackColor = true;
			this.bt_BrowserNext.Click += new System.EventHandler(this.bt_BrowserNext_Click);
			// 
			// bt_BrowserBack
			// 
			this.bt_BrowserBack.Location = new System.Drawing.Point(32, 2);
			this.bt_BrowserBack.Name = "bt_BrowserBack";
			this.bt_BrowserBack.Size = new System.Drawing.Size(60, 27);
			this.bt_BrowserBack.TabIndex = 5;
			this.bt_BrowserBack.Text = "<";
			this.bt_BrowserBack.UseVisualStyleBackColor = true;
			this.bt_BrowserBack.Click += new System.EventHandler(this.bt_BrowserBack_Click);
			// 
			// panel_Browser
			// 
			this.panel_Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_Browser.Location = new System.Drawing.Point(22, 53);
			this.panel_Browser.Name = "panel_Browser";
			this.panel_Browser.Size = new System.Drawing.Size(710, 614);
			this.panel_Browser.TabIndex = 4;
			this.panel_Browser.SizeChanged += new System.EventHandler(this.panel_Browser_SizeChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 670);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(732, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// cmd_Pointer
			// 
			this.cmd_Pointer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmd_Pointer.FormattingEnabled = true;
			this.cmd_Pointer.Location = new System.Drawing.Point(66, 32);
			this.cmd_Pointer.Name = "cmd_Pointer";
			this.cmd_Pointer.Size = new System.Drawing.Size(127, 20);
			this.cmd_Pointer.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 12);
			this.label3.TabIndex = 15;
			this.label3.Text = "ポインター";
			// 
			// bt_WebScrnAll
			// 
			this.bt_WebScrnAll.Location = new System.Drawing.Point(74, 303);
			this.bt_WebScrnAll.Name = "bt_WebScrnAll";
			this.bt_WebScrnAll.Size = new System.Drawing.Size(157, 29);
			this.bt_WebScrnAll.TabIndex = 10;
			this.bt_WebScrnAll.Text = "全体画像取得";
			this.bt_WebScrnAll.UseVisualStyleBackColor = true;
			this.bt_WebScrnAll.Click += new System.EventHandler(this.bt_WebScrnAll_Click);
			// 
			// cb_ImageFrame
			// 
			this.cb_ImageFrame.AutoSize = true;
			this.cb_ImageFrame.Location = new System.Drawing.Point(9, 58);
			this.cb_ImageFrame.Name = "cb_ImageFrame";
			this.cb_ImageFrame.SavedValue = true;
			this.cb_ImageFrame.Size = new System.Drawing.Size(118, 16);
			this.cb_ImageFrame.TabIndex = 9;
			this.cb_ImageFrame.Text = "画像に枠線をつける";
			this.cb_ImageFrame.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.cmb_addInfoPosition);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(228, 182);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "追加情報";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cb_Url);
			this.panel2.Controls.Add(this.tb_Author);
			this.panel2.Controls.Add(this.cb_Version);
			this.panel2.Controls.Add(this.cb_AddSize);
			this.panel2.Controls.Add(this.cb_Author);
			this.panel2.Controls.Add(this.cb_Comment);
			this.panel2.Controls.Add(this.tb_Comment);
			this.panel2.Controls.Add(this.cb_AddDateTime);
			this.panel2.Location = new System.Drawing.Point(0, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(228, 133);
			this.panel2.TabIndex = 10;
			// 
			// cb_Url
			// 
			this.cb_Url.AutoSize = true;
			this.cb_Url.Location = new System.Drawing.Point(9, 3);
			this.cb_Url.Name = "cb_Url";
			this.cb_Url.SavedValue = true;
			this.cb_Url.Size = new System.Drawing.Size(46, 16);
			this.cb_Url.TabIndex = 12;
			this.cb_Url.Text = "URL";
			this.cb_Url.UseVisualStyleBackColor = true;
			// 
			// tb_Author
			// 
			this.tb_Author.EnterTab = false;
			this.tb_Author.Location = new System.Drawing.Point(72, 67);
			this.tb_Author.Name = "tb_Author";
			this.tb_Author.SavedValue = true;
			this.tb_Author.Size = new System.Drawing.Size(150, 19);
			this.tb_Author.TabIndex = 11;
			this.tb_Author.UserValueKey = null;
			// 
			// cb_Version
			// 
			this.cb_Version.AutoSize = true;
			this.cb_Version.Location = new System.Drawing.Point(9, 25);
			this.cb_Version.Name = "cb_Version";
			this.cb_Version.SavedValue = true;
			this.cb_Version.Size = new System.Drawing.Size(69, 16);
			this.cb_Version.TabIndex = 13;
			this.cb_Version.Text = "バージョン";
			this.cb_Version.UseVisualStyleBackColor = true;
			// 
			// cb_AddSize
			// 
			this.cb_AddSize.AutoSize = true;
			this.cb_AddSize.Location = new System.Drawing.Point(9, 47);
			this.cb_AddSize.Name = "cb_AddSize";
			this.cb_AddSize.SavedValue = true;
			this.cb_AddSize.Size = new System.Drawing.Size(87, 16);
			this.cb_AddSize.TabIndex = 4;
			this.cb_AddSize.Text = "ウィンドサイズ";
			this.cb_AddSize.UseVisualStyleBackColor = true;
			// 
			// cb_Author
			// 
			this.cb_Author.AutoSize = true;
			this.cb_Author.Location = new System.Drawing.Point(9, 69);
			this.cb_Author.Name = "cb_Author";
			this.cb_Author.SavedValue = true;
			this.cb_Author.Size = new System.Drawing.Size(60, 16);
			this.cb_Author.TabIndex = 10;
			this.cb_Author.Text = "作成者";
			this.cb_Author.UseVisualStyleBackColor = true;
			// 
			// cb_Comment
			// 
			this.cb_Comment.AutoSize = true;
			this.cb_Comment.Location = new System.Drawing.Point(9, 91);
			this.cb_Comment.Name = "cb_Comment";
			this.cb_Comment.SavedValue = true;
			this.cb_Comment.Size = new System.Drawing.Size(57, 16);
			this.cb_Comment.TabIndex = 6;
			this.cb_Comment.Text = "コメント";
			this.cb_Comment.UseVisualStyleBackColor = true;
			// 
			// tb_Comment
			// 
			this.tb_Comment.EnterTab = false;
			this.tb_Comment.Location = new System.Drawing.Point(72, 89);
			this.tb_Comment.Name = "tb_Comment";
			this.tb_Comment.SavedValue = true;
			this.tb_Comment.Size = new System.Drawing.Size(150, 19);
			this.tb_Comment.TabIndex = 7;
			this.tb_Comment.UserValueKey = null;
			// 
			// cb_AddDateTime
			// 
			this.cb_AddDateTime.AutoSize = true;
			this.cb_AddDateTime.Location = new System.Drawing.Point(9, 113);
			this.cb_AddDateTime.Name = "cb_AddDateTime";
			this.cb_AddDateTime.SavedValue = true;
			this.cb_AddDateTime.Size = new System.Drawing.Size(60, 16);
			this.cb_AddDateTime.TabIndex = 5;
			this.cb_AddDateTime.Text = "現時刻";
			this.cb_AddDateTime.UseVisualStyleBackColor = true;
			// 
			// cmb_addInfoPosition
			// 
			this.cmb_addInfoPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_addInfoPosition.FormattingEnabled = true;
			this.cmb_addInfoPosition.Items.AddRange(new object[] {
            "非表示",
            "上",
            "下"});
			this.cmb_addInfoPosition.Location = new System.Drawing.Point(69, 18);
			this.cmb_addInfoPosition.Name = "cmb_addInfoPosition";
			this.cmb_addInfoPosition.Size = new System.Drawing.Size(121, 20);
			this.cmb_addInfoPosition.TabIndex = 9;
			this.cmb_addInfoPosition.SelectedIndexChanged += new System.EventHandler(this.cmb_addInfoPosition_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "表示位置：";
			// 
			// toolStrip_WindowSize
			// 
			this.toolStrip_WindowSize.AutoSize = false;
			this.toolStrip_WindowSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStrip_WindowSize.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
			this.toolStrip_WindowSize.Name = "toolStrip_WindowSize";
			this.toolStrip_WindowSize.Size = new System.Drawing.Size(90, 17);
			this.toolStrip_WindowSize.Text = "****✕****";
			this.toolStrip_WindowSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "モード";
			// 
			// slider_Vertically
			// 
			this.slider_Vertically.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.slider_Vertically.BackColor = System.Drawing.SystemColors.Control;
			this.slider_Vertically.ContextMenuStrip = this.slider_contextMenuStrip;
			this.slider_Vertically.Location = new System.Drawing.Point(0, 53);
			this.slider_Vertically.Name = "slider_Vertically";
			this.slider_Vertically.Size = new System.Drawing.Size(22, 614);
			this.slider_Vertically.TabIndex = 8;
			this.slider_Vertically.TargetControlSize = new System.Drawing.Size(0, 0);
			// 
			// slider_Horizontally
			// 
			this.slider_Horizontally.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.slider_Horizontally.BackColor = System.Drawing.SystemColors.Control;
			this.slider_Horizontally.ContextMenuStrip = this.slider_contextMenuStrip;
			this.slider_Horizontally.Location = new System.Drawing.Point(22, 31);
			this.slider_Horizontally.Name = "slider_Horizontally";
			this.slider_Horizontally.Size = new System.Drawing.Size(710, 22);
			this.slider_Horizontally.TabIndex = 0;
			this.slider_Horizontally.TargetControlSize = new System.Drawing.Size(0, 0);
			// 
			// ieVersionSelector1
			// 
			this.ieVersionSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ieVersionSelector1.FormattingEnabled = true;
			this.ieVersionSelector1.Location = new System.Drawing.Point(66, 6);
			this.ieVersionSelector1.Name = "ieVersionSelector1";
			this.ieVersionSelector1.Size = new System.Drawing.Size(127, 20);
			this.ieVersionSelector1.TabIndex = 17;
			// 
			// imageCacheViewer1
			// 
			this.imageCacheViewer1.Location = new System.Drawing.Point(2, 338);
			this.imageCacheViewer1.Name = "imageCacheViewer1";
			this.imageCacheViewer1.SelectedIndex = 0;
			this.imageCacheViewer1.Size = new System.Drawing.Size(229, 215);
			this.imageCacheViewer1.TabIndex = 11;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 692);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "MainWindow";
			this.SavedLocation = true;
			this.SavedSize = true;
			this.Text = "ScreenShotsBrowser";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.slider_contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.image_Icon)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bt_WebScrn;
		private System.Windows.Forms.Button bt_Navigated;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStrip_WindowSize;
		private System.Windows.Forms.Button bt_BrowserNext;
		private System.Windows.Forms.Button bt_BrowserBack;
		private System.Windows.Forms.GroupBox groupBox1;
		private XTextBox tb_Comment;
		private XCheckBox cb_AddSize;
		private XCheckBox cb_AddDateTime;
		private XCheckBox cb_Comment;
		private XCheckBox cb_ImageFrame;
		private System.Windows.Forms.ComboBox cmb_addInfoPosition;
		private System.Windows.Forms.Label label1;
		private XTextBox tb_Author;
		private XCheckBox cb_Author;
		private XCheckBox cb_Url;
		private XCheckBox cb_Version;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox image_Icon;
		private LocationHorizontallySlider slider_Horizontally;
		private LocationVerticallySlider slider_Vertically;
		private XCheckBox cb_Slider;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button bt_WebScrnAll;
		private ImageCacheViewer imageCacheViewer1;
		private System.Windows.Forms.ContextMenuStrip slider_contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem 今の位置を保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ComboBox cmd_Url;
		private System.Windows.Forms.Panel panel_Browser;
		private ComboBox cmd_Pointer;
		private Label label3;
		private IeVersionSelector ieVersionSelector1;
		private Label label2;
	}
}

