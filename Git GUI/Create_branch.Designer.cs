namespace Git_GUI
{
    partial class Create_branch
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_branch = new System.Windows.Forms.TextBox();
            this.cb_parent_branch = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_create_and_checkout = new System.Windows.Forms.Button();
            this.name_validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhánh kế thừa";
            // 
            // txt_name_branch
            // 
            this.txt_name_branch.Location = new System.Drawing.Point(15, 44);
            this.txt_name_branch.Name = "txt_name_branch";
            this.txt_name_branch.Size = new System.Drawing.Size(364, 22);
            this.txt_name_branch.TabIndex = 1;
            // 
            // cb_parent_branch
            // 
            this.cb_parent_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parent_branch.FormattingEnabled = true;
            this.cb_parent_branch.Location = new System.Drawing.Point(15, 118);
            this.cb_parent_branch.Name = "cb_parent_branch";
            this.cb_parent_branch.Size = new System.Drawing.Size(364, 24);
            this.cb_parent_branch.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(297, 227);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(209, 227);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(82, 29);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Tạo";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_create_and_checkout
            // 
            this.btn_create_and_checkout.Location = new System.Drawing.Point(36, 227);
            this.btn_create_and_checkout.Name = "btn_create_and_checkout";
            this.btn_create_and_checkout.Size = new System.Drawing.Size(167, 29);
            this.btn_create_and_checkout.TabIndex = 3;
            this.btn_create_and_checkout.Text = "Tạo và chuyển đến";
            this.btn_create_and_checkout.UseVisualStyleBackColor = true;
            this.btn_create_and_checkout.Click += new System.EventHandler(this.btn_create_and_checkout_Click);
            // 
            // name_validate
            // 
            this.name_validate.AutoSize = true;
            this.name_validate.ForeColor = System.Drawing.Color.Red;
            this.name_validate.Location = new System.Drawing.Point(15, 73);
            this.name_validate.Name = "name_validate";
            this.name_validate.Size = new System.Drawing.Size(0, 17);
            this.name_validate.TabIndex = 4;
            // 
            // Create_branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.name_validate);
            this.Controls.Add(this.btn_create_and_checkout);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cb_parent_branch);
            this.Controls.Add(this.txt_name_branch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_branch";
            this.Text = "Tạo nhánh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_branch;
        private System.Windows.Forms.ComboBox cb_parent_branch;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_create_and_checkout;
        private System.Windows.Forms.Label name_validate;
    }
}