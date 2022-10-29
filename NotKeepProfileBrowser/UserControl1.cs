using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwaysSecretBrowser
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Action<string> OnTabNameChange;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (OnTabNameChange != null)
            {
                OnTabNameChange(textBox1.Text);
            }
        }

        private async void UserControl1_Load(object sender, EventArgs e)
        {
            var environment = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(
                null,
                $".\\session\\{DateTime.Now.Ticks}"
            );

            await webView21.EnsureCoreWebView2Async(environment);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void bt_reload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            textBox2.Text = webView21.Source.ToString();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Uri uri = null;
                try
                {
                    uri = new Uri(textBox2.Text);
                }
                catch { }

                if (uri != null)
                {
                    webView21.Source = new Uri(textBox2.Text);
                }
            }
        }
    }
}
