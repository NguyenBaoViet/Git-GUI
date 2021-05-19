namespace Git_GUI
{
    partial class Change_branch_name
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_list_branch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_change_name = new System.Windows.Forms.Button();
            this.name_validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhánh";
            // 
            // cb_list_branch
            // 
            this.cb_list_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_list_branch.FormattingEnabled = true;
            this.cb_list_branch.Location = new System.Drawing.Point(12, 29);
            this.cb_list_branch.Name = "cb_list_branch";
            this.cb_list_branch.Size = new System.Drawing.Size(568, 24);
            this.cb_list_branch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên muốn đổi";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(568, 22);
            this.txt_name.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(468, 131);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 34);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_change_name
            // 
            this.btn_change_name.Location = new System.Drawing.Point(325, 131);
            this.btn_change_name.Name = "btn_change_name";
            this.btn_change_name.Size = new System.Drawing.Size(117, 34);
            this.btn_change_name.TabIndex = 3;
            this.btn_change_name.Text = "Đổi";
            this.btn_change_name.UseVisualStyleBackColor = true;
            this.btn_change_name.Click += new System.EventHandler(this.btn_change_name_Click);
            // 
            // name_validate
            // 
            this.name_validate.AutoSize = true;
            this.name_validate.ForeColor = System.Drawing.Color.Red;
            this.name_validate.Location = new System.Drawing.Point(12, 110);
            this.name_validate.Name = "name_validate";
            this.name_validate.Size = new System.Drawing.Size(0, 17);
            this.name_validate.TabIndex = 4;
            // 
            // Change_branch_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 177);
            this.Controls.Add(this.name_validate);
            this.Controls.Add(this.btn_change_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cb_list_branch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change_branch_name";
            this.Text = "Đổi tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_list_branch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_change_name;
        private System.Windows.Forms.Label name_validate;
    }
}