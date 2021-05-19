namespace Git_GUI
{
    partial class git_GUI
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
            this.brToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoNhánhMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_checkout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_branch = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lb_location = new System.Windows.Forms.Label();
            this.listbox_file_ustaged_changes = new System.Windows.Forms.ListBox();
            this.btn_rescan = new System.Windows.Forms.Button();
            this.txt_file_content = new System.Windows.Forms.RichTextBox();
            this.listbox_staged_change_will_commit = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_commit_message = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brToolStripMenuItem
            // 
            this.brToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoNhánhMớiToolStripMenuItem,
            this.menu_checkout,
            this.menu_rename});
            this.brToolStripMenuItem.Name = "brToolStripMenuItem";
            this.brToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.brToolStripMenuItem.Text = "Nhánh";
            // 
            // tạoNhánhMớiToolStripMenuItem
            // 
            this.tạoNhánhMớiToolStripMenuItem.Name = "tạoNhánhMớiToolStripMenuItem";
            this.tạoNhánhMớiToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tạoNhánhMớiToolStripMenuItem.Text = "Tạo nhánh mới";
            this.tạoNhánhMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoNhánhMớiToolStripMenuItem_Click);
            // 
            // menu_checkout
            // 
            this.menu_checkout.Name = "menu_checkout";
            this.menu_checkout.Size = new System.Drawing.Size(183, 26);
            this.menu_checkout.Text = "Chuyển nhánh";
            this.menu_checkout.Click += new System.EventHandler(this.menu_checkout_Click);
            // 
            // menu_rename
            // 
            this.menu_rename.Name = "menu_rename";
            this.menu_rename.Size = new System.Drawing.Size(183, 26);
            this.menu_rename.Text = "Đổi tên nhánh";
            this.menu_rename.Click += new System.EventHandler(this.menu_rename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhánh làm việc hiện tại :";
            // 
            // lb_branch
            // 
            this.lb_branch.AutoSize = true;
            this.lb_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_branch.Location = new System.Drawing.Point(224, 32);
            this.lb_branch.Name = "lb_branch";
            this.lb_branch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_branch.Size = new System.Drawing.Size(122, 20);
            this.lb_branch.TabIndex = 2;
            this.lb_branch.Text = "current_branch";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(13, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 20);
            this.label.TabIndex = 3;
            this.label.Text = "Đường dẫn kho chứa:";
            // 
            // lb_location
            // 
            this.lb_location.AutoSize = true;
            this.lb_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_location.Location = new System.Drawing.Point(203, 61);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(103, 20);
            this.lb_location.TabIndex = 4;
            this.lb_location.Text = "current_path";
            // 
            // listbox_file_ustaged_changes
            // 
            this.listbox_file_ustaged_changes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_file_ustaged_changes.FormattingEnabled = true;
            this.listbox_file_ustaged_changes.ItemHeight = 20;
            this.listbox_file_ustaged_changes.Location = new System.Drawing.Point(12, 120);
            this.listbox_file_ustaged_changes.Name = "listbox_file_ustaged_changes";
            this.listbox_file_ustaged_changes.Size = new System.Drawing.Size(244, 284);
            this.listbox_file_ustaged_changes.TabIndex = 5;
            this.listbox_file_ustaged_changes.Click += new System.EventHandler(this.listbox_file_ustaged_changes_Click);
            // 
            // btn_rescan
            // 
            this.btn_rescan.Location = new System.Drawing.Point(284, 439);
            this.btn_rescan.Name = "btn_rescan";
            this.btn_rescan.Size = new System.Drawing.Size(133, 30);
            this.btn_rescan.TabIndex = 6;
            this.btn_rescan.Text = "Rescan";
            this.btn_rescan.UseVisualStyleBackColor = true;
            this.btn_rescan.Click += new System.EventHandler(this.btn_rescan_Click);
            // 
            // txt_file_content
            // 
            this.txt_file_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file_content.Location = new System.Drawing.Point(292, 120);
            this.txt_file_content.Name = "txt_file_content";
            this.txt_file_content.ReadOnly = true;
            this.txt_file_content.Size = new System.Drawing.Size(814, 284);
            this.txt_file_content.TabIndex = 7;
            this.txt_file_content.Text = "";
            // 
            // listbox_staged_change_will_commit
            // 
            this.listbox_staged_change_will_commit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_staged_change_will_commit.FormattingEnabled = true;
            this.listbox_staged_change_will_commit.ItemHeight = 20;
            this.listbox_staged_change_will_commit.Location = new System.Drawing.Point(12, 439);
            this.listbox_staged_change_will_commit.Name = "listbox_staged_change_will_commit";
            this.listbox_staged_change_will_commit.Size = new System.Drawing.Size(244, 244);
            this.listbox_staged_change_will_commit.TabIndex = 5;
            this.listbox_staged_change_will_commit.Click += new System.EventHandler(this.listbox_staged_change_will_commit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Các tập tin chưa đánh dấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Các tập tin đã đánh dấu";
            // 
            // txt_commit_message
            // 
            this.txt_commit_message.Location = new System.Drawing.Point(423, 433);
            this.txt_commit_message.Multiline = true;
            this.txt_commit_message.Name = "txt_commit_message";
            this.txt_commit_message.Size = new System.Drawing.Size(683, 250);
            this.txt_commit_message.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Commit Message:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(284, 475);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 30);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Staged Changed";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_commit
            // 
            this.btn_commit.Location = new System.Drawing.Point(284, 511);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(133, 30);
            this.btn_commit.TabIndex = 6;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // git_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 695);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_commit_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_file_content);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_rescan);
            this.Controls.Add(this.listbox_staged_change_will_commit);
            this.Controls.Add(this.listbox_file_ustaged_changes);
            this.Controls.Add(this.lb_location);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lb_branch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "git_GUI";
            this.Text = "Git GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_branch;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lb_location;
        private System.Windows.Forms.ListBox listbox_file_ustaged_changes;
        private System.Windows.Forms.Button btn_rescan;
        private System.Windows.Forms.RichTextBox txt_file_content;
        private System.Windows.Forms.ListBox listbox_staged_change_will_commit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_commit_message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.ToolStripMenuItem tạoNhánhMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_checkout;
        private System.Windows.Forms.ToolStripMenuItem menu_rename;
    }
}