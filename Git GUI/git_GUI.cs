using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Git_GUI
{
    public partial class git_GUI : Form
    {
        private string path;
        private int index = 0;
        string output = "";
        private string[] lines;
        Control control = new Control();
        DialogResult d;
        public git_GUI(string path)
        {
            InitializeComponent();
            this.path = path;
            //cập nhận nhánh hiện tại và đường dẫn đến kho chứa
            lb_branch.Text = control.loading(path, "git branch --show-current");
            lb_location.Text = path;


            //cập nhật các file đang được theo dõi
            reload();
        }

        private void btn_rescan_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                output = control.loading(path, "git add " + listbox_file_ustaged_changes.SelectedItem.ToString());
            }
            catch
            {

            }
            reload();
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            if (txt_commit_message.Text != "")
            {
                try
                {
                    output = control.loading(path, "git commit -m \"" + txt_commit_message.Text + "\"");
                    d = MessageBox.Show("Commit thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                    {
                        reload();

                    }
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Commit Message!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reload()
        {
            listbox_file_ustaged_changes.Items.Clear();
            listbox_staged_change_will_commit.Items.Clear();
            txt_file_content.Clear();
            txt_commit_message.Clear();

            lb_branch.Text = control.loading(path, "git branch --show-current");

            output = control.loading(path, "git status");
            string[] array = output.Split('\n');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToLower() == "untracked files:")
                {
                    for (int j = i + 2; j < array.Length; j++)
                    {
                        if (array[j] == "")
                        {
                            break;
                        }
                        else
                        {
                            listbox_file_ustaged_changes.Items.Add(array[j].Trim());
                        }
                    }
                }
                else if (array[i].ToLower() == "changes to be committed:")
                {
                    for (int j = i + 2; j < array.Length; j++)
                    {
                        if (array[j] == "")
                        {
                            break;
                        }
                        else
                        {
                            string[] array_file_name = array[j].Trim().Split(':');
                            listbox_staged_change_will_commit.Items.Add(array_file_name[1].Trim());
                        }
                    }
                }
                else if (array[i].ToLower() == "changes not staged for commit:")
                {
                    for (int j = i + 3; j < array.Length; j++)
                    {
                        if (array[j] == "")
                        {
                            break;
                        }
                        else
                        {
                            string[] array_file_name = array[j].Trim().Split(':');
                            listbox_file_ustaged_changes.Items.Add(array_file_name[1].Trim());
                        }
                    }
                }
            }
        }

        private void tạoNhánhMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_branch create = new Create_branch(path);
            create.ShowDialog();
            reload();
        }

        private void menu_checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(path);
            checkout.ShowDialog();
            reload();
        }

        private void menu_rename_Click(object sender, EventArgs e)
        {
            Change_branch_name cbn = new Change_branch_name(path);
            cbn.ShowDialog();
            reload();
        }

        private void listbox_file_ustaged_changes_Click(object sender, EventArgs e)
        {
           try
            {
                listbox_staged_change_will_commit.SelectedItems.Clear();
                txt_file_content.Clear();
                output = control.loading(path, "git diff " + listbox_file_ustaged_changes.SelectedItem.ToString());
                if (output.Contains("@"))
                {
                    index = output.IndexOf("@");
                    txt_file_content.Text = output.Substring(index);
                }
                else
                {
                    lines = System.IO.File.ReadAllLines(path + "\\" + listbox_file_ustaged_changes.SelectedItem.ToString());
                    for (int i = 0; i < lines.Length; i++)
                    {
                        txt_file_content.Text += lines[i] + "\n";
                    }
                }
            }
            catch { }
        }

        private void listbox_staged_change_will_commit_Click(object sender, EventArgs e)
        {
            try
            {
                listbox_file_ustaged_changes.SelectedItems.Clear();
                txt_file_content.Clear();
                output = control.loading(path, "git diff --cached " + listbox_staged_change_will_commit.SelectedItem.ToString());
                index = output.IndexOf("@");
                txt_file_content.Text = output.Substring(index);
            }
            catch { }
        }
    }
}
