namespace Git_GUI
{
    partial class Open
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
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_open_repo = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.path_validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(25, 58);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(472, 27);
            this.txt_path.TabIndex = 1;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(503, 54);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(151, 37);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Chọn";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn kho chứa:";
            // 
            // btn_open_repo
            // 
            this.btn_open_repo.Location = new System.Drawing.Point(392, 146);
            this.btn_open_repo.Name = "btn_open_repo";
            this.btn_open_repo.Size = new System.Drawing.Size(123, 36);
            this.btn_open_repo.TabIndex = 4;
            this.btn_open_repo.Text = "Mở ";
            this.btn_open_repo.UseVisualStyleBackColor = true;
            this.btn_open_repo.Click += new System.EventHandler(this.btn_open_repo_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(531, 146);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 36);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // path_validate
            // 
            this.path_validate.AutoSize = true;
            this.path_validate.ForeColor = System.Drawing.Color.Red;
            this.path_validate.Location = new System.Drawing.Point(22, 88);
            this.path_validate.Name = "path_validate";
            this.path_validate.Size = new System.Drawing.Size(0, 17);
            this.path_validate.TabIndex = 5;
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 194);
            this.Controls.Add(this.path_validate);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_open_repo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txt_path);
            this.Name = "Open";
            this.Text = "Open";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_open_repo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label path_validate;
    }
}