using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_repo add = new Add_repo();
            add.ShowDialog();
        }

        private void add_repo_Click(object sender, EventArgs e)
        {
            Add_repo add = new Add_repo();
            add.ShowDialog();
        }

        private void open_exist_repo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Open open = new Open();
            open.Show();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            Open open = new Open();
            open.ShowDialog();
        }

        private void menu_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
