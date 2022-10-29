namespace NKPB
{
    partial class BrowserControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tb_Caption = new System.Windows.Forms.TextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_reload = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bt_Color = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(3, 50);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(453, 201);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            this.webView.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView_SourceChanged);
            // 
            // tb_Caption
            // 
            this.tb_Caption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Caption.Location = new System.Drawing.Point(3, 3);
            this.tb_Caption.Name = "tb_Caption";
            this.tb_Caption.Size = new System.Drawing.Size(149, 19);
            this.tb_Caption.TabIndex = 1;
            this.tb_Caption.TextChanged += new System.EventHandler(this.tb_Caption_TextChanged);
            // 
            // tb_url
            // 
            this.tb_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_url.Location = new System.Drawing.Point(112, 26);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(344, 19);
            this.tb_url.TabIndex = 2;
            this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_url_KeyDown);
            // 
            // bt_back
            // 
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Location = new System.Drawing.Point(3, 24);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(29, 21);
            this.bt_back.TabIndex = 3;
            this.bt_back.Text = "<<";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_next
            // 
            this.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_next.Location = new System.Drawing.Point(31, 24);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(29, 21);
            this.bt_next.TabIndex = 4;
            this.bt_next.Text = ">>";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_reload
            // 
            this.bt_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reload.Location = new System.Drawing.Point(62, 24);
            this.bt_reload.Name = "bt_reload";
            this.bt_reload.Size = new System.Drawing.Size(47, 21);
            this.bt_reload.TabIndex = 5;
            this.bt_reload.Text = "再読";
            this.bt_reload.UseVisualStyleBackColor = true;
            this.bt_reload.Click += new System.EventHandler(this.bt_reload_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.SystemColors.Control;
            // 
            // bt_Color
            // 
            this.bt_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Color.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Color.Location = new System.Drawing.Point(421, 0);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(35, 23);
            this.bt_Color.TabIndex = 6;
            this.bt_Color.UseVisualStyleBackColor = false;
            this.bt_Color.Click += new System.EventHandler(this.bt_Color_Click);
            // 
            // BrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_Color);
            this.Controls.Add(this.bt_reload);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.tb_Caption);
            this.Controls.Add(this.webView);
            this.Name = "BrowserControl";
            this.Size = new System.Drawing.Size(459, 254);
            this.Load += new System.EventHandler(this.BrowserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox tb_Caption;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_reload;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button bt_Color;
    }
}
