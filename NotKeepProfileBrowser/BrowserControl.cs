using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKPB
{
    public partial class BrowserControl : UserControl
    {
        public BrowserControl(Profile profile)
        {
            this.Profile = profile;
            InitializeComponent();

            if(profile.Type == ProfileType.Default)
            {
                tb_Caption.Text = profile.Name;
                tb_Caption.ReadOnly = true;
            }
        }

        public Action<string> OnTabNameChange;

        public Profile Profile { get; private set; }
        public string Caption { get { return tb_Caption.Text; } }

        private void tb_Caption_TextChanged(object sender, EventArgs e)
        {
            if (tb_Caption.ReadOnly)
            {
                return;
            }

            if (OnTabNameChange != null)
            {
                OnTabNameChange(tb_Caption.Text);
            }
        }

        private async void BrowserControl_Load(object sender, EventArgs e)
        {
            var environment = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(
                null,
                Profile.Directory
            );

            await webView.EnsureCoreWebView2Async(environment);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            webView.GoForward();
        }

        private void bt_reload_Click(object sender, EventArgs e)
        {
            webView.Reload();
        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            tb_url.Text = webView.Source.ToString();
        }

        private void tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                Uri uri = null;
                try
                {
                    uri = new Uri(tb_url.Text);
                }
                catch { }

                if (uri != null)
                {
                    webView.Source = new Uri(tb_url.Text);
                }
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Color_Click(object sender, EventArgs e)
        {
            if( colorDialog.ShowDialog() == DialogResult.OK)
            {
                bt_Color.BackColor = colorDialog.Color;
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
