using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_GUI
{
    public partial class Create_branch : Form
    {
        Control control = new Control();
        DialogResult d;
        private string output = "";
        private string path = "";
        private string[] array;
        private int index = 0;

        public Create_branch(string path)
        {
            InitializeComponent();
            this.path = path;
            output = control.loading(path, "git branch");
            array = output.Split('\n');

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != null)
                {
                    if (array[i].StartsWith("*"))
                    {
                        cb_parent_branch.Items.Add(array[i].Substring(2));
                        index = cb_parent_branch.Items.IndexOf(array[i].Substring(2));
                        cb_parent_branch.SelectedIndex = index;
                    }
                    else
                    {
                        array[i] = array[i].Trim();
                        cb_parent_branch.Items.Add(array[i]);
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_name_branch.Text.Trim() != "")
            {
                if (txt_name_branch.Text.Trim().Contains(" "))
                {
                    d = MessageBox.Show("Tên nhánh sẽ được tạo dạng: " + txt_name_branch.Text.Trim().Replace(' ', '-') + ". Bạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        output = control.loading(path, "git branch " + txt_name_branch.Text.Trim().Replace(' ', '-') + " " + cb_parent_branch.SelectedItem);
                        this.Close();
                    }
                }
                else
                {
                    output = control.loading(path, "git branch " + txt_name_branch.Text.Trim() + " " + cb_parent_branch.SelectedItem);
                    this.Close();
                }
            }
            else
            {
                name_validate.Text = "Vui lòng nhập tên nhánh muốn tạo.";
            }
        }

        private void btn_create_and_checkout_Click(object sender, EventArgs e)
        {
            if (txt_name_branch.Text.Trim() != "")
            {
                if (txt_name_branch.Text.Trim().Contains(" "))
                {
                    d = MessageBox.Show("Tên nhánh sẽ được tạo dạng: " + txt_name_branch.Text.Trim().Replace(' ', '-') + ". Bạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        output = control.loading(path, "git checkout -b " + txt_name_branch.Text.Trim().Replace(' ', '-') + " " + cb_parent_branch.SelectedItem);
                        this.Close();
                    }
                }
                else
                {
                    output = control.loading(path, "git checkout -b " + txt_name_branch.Text.Trim() + " " + cb_parent_branch.SelectedItem);
                    this.Close();
                }
            }
            else
            {
                name_validate.Text = "Vui lòng nhập tên nhánh muốn tạo.";
            }
        }
    }
}
