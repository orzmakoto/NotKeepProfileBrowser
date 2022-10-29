namespace NKPB
{
    partial class MailForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.rtb_memo = new System.Windows.Forms.RichTextBox();
            this.bt_OpenNewBrowser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_NameNew = new System.Windows.Forms.Button();
            this.list_Names = new System.Windows.Forms.ListBox();
            this.bt_NameOpne = new System.Windows.Forms.Button();
            this.bt_NameDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu_tab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_tab_閉じる = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenu_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.groupBox2);
            this.Main.Controls.Add(this.bt_OpenNewBrowser);
            this.Main.Controls.Add(this.groupBox1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(792, 424);
            this.Main.TabIndex = 0;
            this.Main.Text = "メイン";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // rtb_memo
            // 
            this.rtb_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_memo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_memo.Location = new System.Drawing.Point(6, 39);
            this.rtb_memo.Name = "rtb_memo";
            this.rtb_memo.Size = new System.Drawing.Size(587, 358);
            this.rtb_memo.TabIndex = 0;
            this.rtb_memo.Text = "";
            // 
            // bt_OpenNewBrowser
            // 
            this.bt_OpenNewBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_OpenNewBrowser.Location = new System.Drawing.Point(14, 15);
            this.bt_OpenNewBrowser.Name = "bt_OpenNewBrowser";
            this.bt_OpenNewBrowser.Size = new System.Drawing.Size(154, 23);
            this.bt_OpenNewBrowser.TabIndex = 1;
            this.bt_OpenNewBrowser.Text = "新しい匿名ブラウザを開く";
            this.bt_OpenNewBrowser.UseVisualStyleBackColor = true;
            this.bt_OpenNewBrowser.Click += new System.EventHandler(this.bt_OpenNewBrowser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_NameDelete);
            this.groupBox1.Controls.Add(this.bt_NameOpne);
            this.groupBox1.Controls.Add(this.list_Names);
            this.groupBox1.Controls.Add(this.bt_NameNew);
            this.groupBox1.Location = new System.Drawing.Point(8, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "名前付きブラウザ";
            // 
            // bt_NameNew
            // 
            this.bt_NameNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NameNew.Location = new System.Drawing.Point(6, 179);
            this.bt_NameNew.Name = "bt_NameNew";
            this.bt_NameNew.Size = new System.Drawing.Size(154, 23);
            this.bt_NameNew.TabIndex = 4;
            this.bt_NameNew.Text = "新しい名前付きブラウザを開く";
            this.bt_NameNew.UseVisualStyleBackColor = true;
            this.bt_NameNew.Click += new System.EventHandler(this.bt_NameNew_Click);
            // 
            // list_Names
            // 
            this.list_Names.FormattingEnabled = true;
            this.list_Names.ItemHeight = 12;
            this.list_Names.Location = new System.Drawing.Point(6, 18);
            this.list_Names.Name = "list_Names";
            this.list_Names.Size = new System.Drawing.Size(154, 88);
            this.list_Names.TabIndex = 4;
            this.list_Names.DoubleClick += new System.EventHandler(this.list_Names_DoubleClick);
            // 
            // bt_NameOpne
            // 
            this.bt_NameOpne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NameOpne.Location = new System.Drawing.Point(6, 112);
            this.bt_NameOpne.Name = "bt_NameOpne";
            this.bt_NameOpne.Size = new System.Drawing.Size(154, 23);
            this.bt_NameOpne.TabIndex = 5;
            this.bt_NameOpne.Text = "開く";
            this.bt_NameOpne.UseVisualStyleBackColor = true;
            this.bt_NameOpne.Click += new System.EventHandler(this.bt_NameOpne_Click);
            // 
            // bt_NameDelete
            // 
            this.bt_NameDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NameDelete.Location = new System.Drawing.Point(6, 141);
            this.bt_NameDelete.Name = "bt_NameDelete";
            this.bt_NameDelete.Size = new System.Drawing.Size(154, 23);
            this.bt_NameDelete.TabIndex = 6;
            this.bt_NameDelete.Text = "削除";
            this.bt_NameDelete.UseVisualStyleBackColor = true;
            this.bt_NameDelete.Click += new System.EventHandler(this.bt_NameDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rtb_memo);
            this.groupBox2.Location = new System.Drawing.Point(185, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 403);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "メモ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "自由に記述可能なメモエリアです。ブラウザ終了時に保存されます。";
            // 
            // contextMenu_tab
            // 
            this.contextMenu_tab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_tab_閉じる});
            this.contextMenu_tab.Name = "contextMenu_tab";
            this.contextMenu_tab.Size = new System.Drawing.Size(105, 26);
            // 
            // ToolStripMenuItem_tab_閉じる
            // 
            this.ToolStripMenuItem_tab_閉じる.Name = "ToolStripMenuItem_tab_閉じる";
            this.ToolStripMenuItem_tab_閉じる.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_tab_閉じる.Text = "閉じる";
            this.ToolStripMenuItem_tab_閉じる.Click += new System.EventHandler(this.ToolStripMenuItem_tab_閉じる_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailForm";
            this.Text = "NotKeepProfileBrowser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MailForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenu_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.RichTextBox rtb_memo;
        private System.Windows.Forms.Button bt_OpenNewBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_NameDelete;
        private System.Windows.Forms.Button bt_NameOpne;
        private System.Windows.Forms.ListBox list_Names;
        private System.Windows.Forms.Button bt_NameNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenu_tab;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_tab_閉じる;
    }
}

