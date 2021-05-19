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
    public partial class Checkout : Form
    {
        private string path = "";
        private string output = "";
        private string[] array;
        private int index = 0;
        Control control = new Control();
        public Checkout(string path)
        {
            InitializeComponent();
            this.path = path;
            output = control.loading(path, "git branch");
            array = output.Split('\n');

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != "")
                {
                    if (array[i].StartsWith("*"))
                    {
                        cb_list_branch_name.Items.Add(array[i].Substring(2));
                        index = cb_list_branch_name.Items.IndexOf(array[i].Substring(2));
                        cb_list_branch_name.SelectedIndex = index;
                    }
                    else
                    {
                        array[i] = array[i].Trim();
                        cb_list_branch_name.Items.Add(array[i]);
                    }
                }
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            output = control.loading(path, "git checkout " + cb_list_branch_name.SelectedItem);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
