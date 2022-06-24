namespace 学生管理系统
{
    partial class Form5
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.工号 = new System.Windows.Forms.TextBox();
            this.班级 = new System.Windows.Forms.TextBox();
            this.年龄 = new System.Windows.Forms.TextBox();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(169, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "信息完善";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(126, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(126, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "年龄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(112, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "教工号：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(61, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "班级（xx专业x班）：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // 工号
            // 
            this.工号.Location = new System.Drawing.Point(206, 100);
            this.工号.Name = "工号";
            this.工号.Size = new System.Drawing.Size(122, 21);
            this.工号.TabIndex = 1;
            this.工号.TextChanged += new System.EventHandler(this.工号_TextChanged);
            // 
            // 班级
            // 
            this.班级.Location = new System.Drawing.Point(206, 223);
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(122, 21);
            this.班级.TabIndex = 4;
            this.班级.TextChanged += new System.EventHandler(this.班级_TextChanged);
            // 
            // 年龄
            // 
            this.年龄.Location = new System.Drawing.Point(206, 180);
            this.年龄.Name = "年龄";
            this.年龄.Size = new System.Drawing.Size(122, 21);
            this.年龄.TabIndex = 3;
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(206, 139);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(122, 21);
            this.姓名.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(173, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.年龄);
            this.Controls.Add(this.班级);
            this.Controls.Add(this.工号);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "信息完善";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 工号;
        private System.Windows.Forms.TextBox 班级;
        private System.Windows.Forms.TextBox 年龄;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Button button1;
    }
}