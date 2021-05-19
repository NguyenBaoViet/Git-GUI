using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_GUI
{
    public partial class Add_repo : Form
    {
        private string path = "";
        private string output = "";
        private string name = "";
        DialogResult d;
        Control control = new Control();
        public Add_repo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //tạo thư mục có tên theo yêu cầu
            if (txt_name.Text != "" && txt_path.Text != "")
            {
                path = txt_path.Text;
                if (txt_name.Text.Trim().Contains(" ")) 
                {
                    name = txt_name.Text.Trim().Replace(' ', '-');
                    d = MessageBox.Show("Tên của kho chứa sẽ được tạo dưới dạng: " + name + ". Bạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        output = control.loading(path, "mkdir " + name);

                        Thread.Sleep(300);

                        path = txt_path.Text + @"\" + name;
                        output = control.loading(path, "git init");
                        d = MessageBox.Show("Tạo kho chứa thành công", "Thông báo", MessageBoxButtons.OK);
                        if (d == DialogResult.OK)
                        {
                            git_GUI gui = new git_GUI(path);
                            gui.Show();
                            this.Close();
                        }
                    }
                }
                else
                {
                    output = control.loading(path, "mkdir " + txt_name.Text.Trim());

                    Thread.Sleep(300);

                    path = txt_path.Text + @"\" + txt_name.Text.Trim();
                    output = control.loading(path, "git init");
                    d = MessageBox.Show("Tạo kho chứa thành công", "Thông báo", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        git_GUI gui = new git_GUI(path);
                        gui.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                if (txt_name.Text == "")
                    name_validate.Text = "Vui lòng nhập tên kho chứa.";
                else name_validate.Text = "";

                if (txt_path.Text == "")
                    path_validate.Text = "Vui lòng chọn đường dẫn.";
                else path_validate.Text = "";
            }
            
        }
    }
}
