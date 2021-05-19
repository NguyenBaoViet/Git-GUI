namespace Git_GUI
{
    partial class Add_repo
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.name_validate = new System.Windows.Forms.Label();
            this.path_validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kho chứa";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(363, 22);
            this.txt_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn đường dẫn";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(12, 111);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(282, 22);
            this.txt_path.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(142, 212);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(109, 33);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Tạo";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(267, 212);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 33);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // name_validate
            // 
            this.name_validate.AutoSize = true;
            this.name_validate.ForeColor = System.Drawing.Color.Red;
            this.name_validate.Location = new System.Drawing.Point(12, 54);
            this.name_validate.Name = "name_validate";
            this.name_validate.Size = new System.Drawing.Size(0, 17);
            this.name_validate.TabIndex = 8;
            // 
            // path_validate
            // 
            this.path_validate.AutoSize = true;
            this.path_validate.ForeColor = System.Drawing.Color.Red;
            this.path_validate.Location = new System.Drawing.Point(12, 136);
            this.path_validate.Name = "path_validate";
            this.path_validate.Size = new System.Drawing.Size(0, 17);
            this.path_validate.TabIndex = 8;
            // 
            // Add_repo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 257);
            this.Controls.Add(this.path_validate);
            this.Controls.Add(this.name_validate);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_repo";
            this.Text = "Create a new repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label name_validate;
        private System.Windows.Forms.Label path_validate;
    }
}