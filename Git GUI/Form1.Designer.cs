namespace Git_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.Button();
            this.link_new = new System.Windows.Forms.LinkLabel();
            this.link_open = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_open,
            this.menu_quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_new
            // 
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(216, 26);
            this.menu_new.Text = "Tạo kho chứa";
            this.menu_new.Click += new System.EventHandler(this.add_repo_Click);
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(216, 26);
            this.menu_open.Text = "Mở kho chứa có sẳn";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // menu_quit
            // 
            this.menu_quit.Name = "menu_quit";
            this.menu_quit.Size = new System.Drawing.Size(216, 26);
            this.menu_quit.Text = "Thoát";
            this.menu_quit.Click += new System.EventHandler(this.menu_quit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(698, 207);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 31);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // link_new
            // 
            this.link_new.AutoSize = true;
            this.link_new.Location = new System.Drawing.Point(162, 41);
            this.link_new.Name = "link_new";
            this.link_new.Size = new System.Drawing.Size(95, 17);
            this.link_new.TabIndex = 5;
            this.link_new.TabStop = true;
            this.link_new.Text = "Tạo kho chứa";
            this.link_new.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // link_open
            // 
            this.link_open.AutoSize = true;
            this.link_open.Location = new System.Drawing.Point(162, 81);
            this.link_open.Name = "link_open";
            this.link_open.Size = new System.Drawing.Size(162, 17);
            this.link_open.TabIndex = 6;
            this.link_open.TabStop = true;
            this.link_open.Text = "Mở một kho chứa có sẳn";
            this.link_open.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.open_exist_repo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 250);
            this.Controls.Add(this.link_open);
            this.Controls.Add(this.link_new);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Git GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.LinkLabel link_new;
        private System.Windows.Forms.LinkLabel link_open;
        private System.Windows.Forms.ToolStripMenuItem menu_quit;
    }
}

