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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //AddNewTab();
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            AddNewTab();
        }

        private void AddNewTab()
        {
            var newTabContent = new UserControl1();
            var newTabPage = new TabPage();

            newTabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabContent.Location = new System.Drawing.Point(3, 3);
            newTabContent.Name = "userControl11";
            //newTabContent.Size = new System.Drawing.Size(786, 418);
            newTabContent.TabIndex = 0;
            newTabContent.OnTabNameChange = (text) =>
            {
                newTabPage.Text = text;
            };

            newTabPage.Controls.Add(newTabContent);
            newTabPage.Location = new System.Drawing.Point(4, 22);
            newTabPage.Name = $"tabPage{tabControl1.TabPages.Count + 1}";
            newTabPage.Padding = new System.Windows.Forms.Padding(3);
            newTabPage.Size = new System.Drawing.Size(792, 424);
            newTabPage.TabIndex = 0;
            newTabPage.Text = "新しいページ";
            newTabPage.UseVisualStyleBackColor = true;

            tabControl1.TabPages.Add(newTabPage);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
