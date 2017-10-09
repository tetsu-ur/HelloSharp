namespace HelloSharp
{
    partial class FormTest
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemウィンドウ = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem設定ファイルを開く = new System.Windows.Forms.ToolStripMenuItem();
            this.アプリの場所を開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFileRead = new System.Windows.Forms.Button();
            this.buttonClearDataGridView = new System.Windows.Forms.Button();
            this.checkHasTitle = new System.Windows.Forms.CheckBox();
            this.comboFilterItem = new System.Windows.Forms.ComboBox();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ボタン";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(645, 75);
            this.textBox1.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(94, 43);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemウィンドウ});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemウィンドウ
            // 
            this.ToolStripMenuItemウィンドウ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem設定ファイルを開く,
            this.アプリの場所を開くToolStripMenuItem,
            this.ToolStripMenuItemCloseWindow});
            this.ToolStripMenuItemウィンドウ.Name = "ToolStripMenuItemウィンドウ";
            this.ToolStripMenuItemウィンドウ.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItemウィンドウ.Text = "ウィンドウ";
            // 
            // ToolStripMenuItem設定ファイルを開く
            // 
            this.ToolStripMenuItem設定ファイルを開く.Name = "ToolStripMenuItem設定ファイルを開く";
            this.ToolStripMenuItem設定ファイルを開く.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem設定ファイルを開く.Text = "設定ファイルを開く";
            this.ToolStripMenuItem設定ファイルを開く.Click += new System.EventHandler(this.ToolStripMenuItem設定ファイルを開く_Click);
            // 
            // アプリの場所を開くToolStripMenuItem
            // 
            this.アプリの場所を開くToolStripMenuItem.Name = "アプリの場所を開くToolStripMenuItem";
            this.アプリの場所を開くToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.アプリの場所を開くToolStripMenuItem.Text = "アプリの場所を開く";
            this.アプリの場所を開くToolStripMenuItem.Click += new System.EventHandler(this.アプリの場所を開くToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemCloseWindow
            // 
            this.ToolStripMenuItemCloseWindow.Name = "ToolStripMenuItemCloseWindow";
            this.ToolStripMenuItemCloseWindow.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItemCloseWindow.Text = "閉じる";
            this.ToolStripMenuItemCloseWindow.Click += new System.EventHandler(this.ToolStripMenuItemCloseWindow_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(670, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textFilename
            // 
            this.textFilename.AllowDrop = true;
            this.textFilename.Location = new System.Drawing.Point(13, 155);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(279, 19);
            this.textFilename.TabIndex = 5;
            this.textFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox2_DragDrop);
            this.textFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox2_DragEnter);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Tipテキスト";
            this.notifyIcon1.BalloonTipTitle = "Tipタイトル";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "C#テストです";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(645, 168);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonFileRead
            // 
            this.buttonFileRead.Location = new System.Drawing.Point(442, 153);
            this.buttonFileRead.Name = "buttonFileRead";
            this.buttonFileRead.Size = new System.Drawing.Size(75, 23);
            this.buttonFileRead.TabIndex = 7;
            this.buttonFileRead.Text = "読み込み";
            this.buttonFileRead.UseVisualStyleBackColor = true;
            this.buttonFileRead.Click += new System.EventHandler(this.buttonFileRead_Click);
            // 
            // buttonClearDataGridView
            // 
            this.buttonClearDataGridView.Location = new System.Drawing.Point(523, 153);
            this.buttonClearDataGridView.Name = "buttonClearDataGridView";
            this.buttonClearDataGridView.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDataGridView.TabIndex = 8;
            this.buttonClearDataGridView.Text = "クリア";
            this.buttonClearDataGridView.UseVisualStyleBackColor = true;
            this.buttonClearDataGridView.Click += new System.EventHandler(this.buttonClearDataGridView_Click);
            // 
            // checkHasTitle
            // 
            this.checkHasTitle.AutoSize = true;
            this.checkHasTitle.Checked = true;
            this.checkHasTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHasTitle.Location = new System.Drawing.Point(303, 157);
            this.checkHasTitle.Name = "checkHasTitle";
            this.checkHasTitle.Size = new System.Drawing.Size(113, 16);
            this.checkHasTitle.TabIndex = 9;
            this.checkHasTitle.Text = "１行目がタイトル行";
            this.checkHasTitle.UseVisualStyleBackColor = true;
            // 
            // comboFilterItem
            // 
            this.comboFilterItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterItem.FormattingEnabled = true;
            this.comboFilterItem.Location = new System.Drawing.Point(82, 183);
            this.comboFilterItem.Name = "comboFilterItem";
            this.comboFilterItem.Size = new System.Drawing.Size(121, 20);
            this.comboFilterItem.TabIndex = 10;
            this.comboFilterItem.SelectedIndexChanged += new System.EventHandler(this.comboFilterItem_SelectedIndexChanged);
            this.comboFilterItem.TextChanged += new System.EventHandler(this.comboFilterItem_TextChanged);
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(223, 184);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(177, 19);
            this.textFilter.TabIndex = 11;
            this.textFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "絞り込み：";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.comboFilterItem);
            this.Controls.Add(this.checkHasTitle);
            this.Controls.Add(this.buttonClearDataGridView);
            this.Controls.Add(this.buttonFileRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textFilename);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::HelloSharp.Properties.Settings.Default, "FormTestLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::HelloSharp.Properties.Settings.Default.FormTestLocation;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTest";
            this.Text = "C#テスト";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.Shown += new System.EventHandler(this.FormTest_Shown);
            this.ClientSizeChanged += new System.EventHandler(this.FormTest_ClientSizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemウィンドウ;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseWindow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem設定ファイルを開く;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem アプリの場所を開くToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFileRead;
        private System.Windows.Forms.Button buttonClearDataGridView;
        private System.Windows.Forms.CheckBox checkHasTitle;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboFilterItem;
    }
}

