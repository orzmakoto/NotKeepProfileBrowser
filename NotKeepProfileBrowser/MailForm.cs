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
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            foreach (var profile in ProfileManager.GetProfiles(ProfileType.Default))
            {
                list_Names.Items.Add(profile);
            }
            rtb_memo.Text = ProfileManager.LoadMemo();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProfileManager.RemoveProfiles(ProfileType.Temporary);

            ProfileManager.SaveMemo(rtb_memo.Text);
        }


        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            AddNewTab(ProfileType.Temporary);
        }

        private void AddNewTab(ProfileType profileType, string name = "")
        {
            AddNewTab(ProfileManager.CreateNewProfile(profileType, name));
        }
        private void AddNewTab(Profile profile)
        {
            var newTabContent = new BrowserControl(profile);
            var newTabPage = new TabPage();

            newTabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabContent.Location = new System.Drawing.Point(3, 3);
            newTabContent.Name = $"userControl{tabControl1.TabPages.Count + 1}";
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
            newTabPage.Text = profile.Type == ProfileType.Temporary ? "新しいページ" : profile.Name;
            newTabPage.ContextMenuStrip = this.contextMenu_tab;

            newTabPage.UseVisualStyleBackColor = true;

            tabControl1.TabPages.Add(newTabPage);
        }

        private void bt_OpenNewBrowser_Click(object sender, EventArgs e)
        {
            AddNewTab(ProfileType.Temporary);
        }

        private void bt_NameNew_Click(object sender, EventArgs e)
        {
            var inputForm = new SubForm.InputNameForm("新しいブラウザ名");
            inputForm.StartPosition = FormStartPosition.CenterScreen;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var profile = ProfileManager.CreateNewProfile(ProfileType.Default, inputForm.InputText);
                list_Names.Items.Add(profile);
                AddNewTab(profile);
            }
        }

        private void bt_NameDelete_Click(object sender, EventArgs e)
        {
            var selectProfile = list_Names.SelectedItem;
            if (selectProfile == null)
            {
                return;
            }
            var profile = selectProfile as Profile;

            if (MessageBox.Show($"ブラウザ {profile.Name}を削除しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }

            if (ProfileManager.RemoveProfile(selectProfile as Profile) == true)
            {
                list_Names.Items.Remove(selectProfile);
            }
            else
            {
                MessageBox.Show("削除に失敗しました。ブラウザが開かれている場合には削除できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_NameOpne_Click(object sender, EventArgs e)
        {
            var selectProfile = list_Names.SelectedItem;
            if (selectProfile == null)
            {
                return;
            }
            AddNewTab(selectProfile as Profile);
        }

        private void list_Names_DoubleClick(object sender, EventArgs e)
        {
            bt_NameOpne_Click(sender, e);
        }

        private void ToolStripMenuItem_tab_閉じる_Click(object sender, EventArgs e)
        {
            var browserControl = tabControl1.SelectedTab.Controls[0] as BrowserControl;
            var profile = browserControl.Profile;
            if (MessageBox.Show($"ブラウザ {browserControl.Caption}を閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            browserControl.Dispose();

            if(profile.Type == ProfileType.Temporary)
            {
                ProfileManager.RemoveProfile(profile);
            }
        }
    }
}
