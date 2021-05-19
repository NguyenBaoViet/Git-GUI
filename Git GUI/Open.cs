using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Git_GUI
{
    public partial class Open : Form
    {
        private string path = "";
        public Open()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_open_repo_Click(object sender, EventArgs e)
        {
            if (txt_path.Text != "")
            {
                path = txt_path.Text;
                if (Directory.Exists(path + @"\.git"))
                {
                    git_GUI git = new git_GUI(path);
                    git.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tồn tại kho chứa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                path_validate.Text = "Vui lòng chọn đường dẫn.";
            }
        }
    }
}