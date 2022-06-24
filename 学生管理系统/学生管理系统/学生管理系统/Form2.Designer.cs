namespace 学生管理系统
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.账号框 = new System.Windows.Forms.TextBox();
            this.密码框 = new System.Windows.Forms.TextBox();
            this.登录按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(161, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(80, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "请输入账号：";
            // 
            // 账号框
            // 
            this.账号框.Location = new System.Drawing.Point(186, 92);
            this.账号框.Name = "账号框";
            this.账号框.Size = new System.Drawing.Size(130, 21);
            this.账号框.TabIndex = 0;
            this.账号框.TextChanged += new System.EventHandler(this.账号框_TextChanged);
            // 
            // 密码框
            // 
            this.密码框.Location = new System.Drawing.Point(186, 140);
            this.密码框.Name = "密码框";
            this.密码框.PasswordChar = '*';
            this.密码框.Size = new System.Drawing.Size(130, 21);
            this.密码框.TabIndex = 1;
            this.密码框.TextChanged += new System.EventHandler(this.密码框_TextChanged);
            // 
            // 登录按钮
            // 
            this.登录按钮.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录按钮.Location = new System.Drawing.Point(150, 219);
            this.登录按钮.Name = "登录按钮";
            this.登录按钮.Size = new System.Drawing.Size(75, 23);
            this.登录按钮.TabIndex = 2;
            this.登录按钮.TabStop = false;
            this.登录按钮.Text = "登录";
            this.登录按钮.UseVisualStyleBackColor = true;
            this.登录按钮.Click += new System.EventHandler(this.登录按钮_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.Controls.Add(this.登录按钮);
            this.Controls.Add(this.密码框);
            this.Controls.Add(this.账号框);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "登录页";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 账号框;
        private System.Windows.Forms.TextBox 密码框;
        private System.Windows.Forms.Button 登录按钮;
    }
}