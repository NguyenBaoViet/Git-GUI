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
    public partial class Change_branch_name : Form
    {
        private string path = "";
        private string output = "";
        private string[] array;
        private int index = 0;
        Control control = new Control();
        DialogResult d;

        public Change_branch_name(string path)
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
                        cb_list_branch.Items.Add(array[i].Substring(2));
                        index = cb_list_branch.Items.IndexOf(array[i].Substring(2));
                        cb_list_branch.SelectedIndex = index;
                    }
                    else
                    {
                        array[i] = array[i].Trim();
                        cb_list_branch.Items.Add(array[i]);
                    }
                }
            }
        }

        private void btn_change_name_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() != "")
            {
                if (txt_name.Text.Trim().Contains(" "))
                {
                    d = MessageBox.Show("Tên nhánh sẽ được đổi thành: " + txt_name.Text.Trim().Replace(' ', '-') + ". Bạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        output = control.loading(path, "git branch -m " + cb_list_branch.SelectedItem + " " + txt_name.Text.Trim().Replace(' ', '-'));
                        this.Close();
                    }
                }
                else
                {
                    output = control.loading(path, "git branch -m " + cb_list_branch.SelectedItem + " " + txt_name.Text.Trim());
                    this.Close();
                }
            }
            else
            {
                name_validate.Text = "Vui lòng nhập tên nhánh muốn đổi.";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
