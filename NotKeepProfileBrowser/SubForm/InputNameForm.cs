using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKPB.SubForm
{
    public partial class InputNameForm : Form
    {
        public InputNameForm(string title = "")
        {
            InitializeComponent();
            this.MaximizeBox = false;  // 最大化ボタンを表示しない
            this.MinimizeBox = false;  // 最小化ボタンを表示しない
            this.ShowInTaskbar = false;  // タスクバーに表示しない


            // 表示位置の設定
            this.StartPosition =FormStartPosition.CenterParent; // 親フォームの中央に配置
            Text = title;

            DialogResult = DialogResult.Cancel;
        }

        public string InputText
        {
            get
            {
                return tb_Input.Text;
            }
        }

        //public bool IsOK { get; private set; } = false;

        private void bt_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
