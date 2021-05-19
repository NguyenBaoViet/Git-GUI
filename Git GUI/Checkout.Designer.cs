namespace Git_GUI
{
    partial class Checkout
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
            this.cb_list_branch_name = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
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
            // cb_list_branch_name
            // 
            this.cb_list_branch_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_list_branch_name.FormattingEnabled = true;
            this.cb_list_branch_name.Location = new System.Drawing.Point(12, 29);
            this.cb_list_branch_name.Name = "cb_list_branch_name";
            this.cb_list_branch_name.Size = new System.Drawing.Size(529, 24);
            this.cb_list_branch_name.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(443, 79);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 31);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(327, 79);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(98, 31);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Chuyển";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 122);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cb_list_branch_name);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Chuyển nhánh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_list_branch_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_checkout;
    }
}