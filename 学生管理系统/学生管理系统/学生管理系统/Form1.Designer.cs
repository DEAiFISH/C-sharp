using System;
using System.Windows.Forms;

namespace 学生管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.教师登录 = new System.Windows.Forms.Button();
            this.学生登陆 = new System.Windows.Forms.Button();
            this.root登录 = new System.Windows.Forms.Button();
            this.退出 = new System.Windows.Forms.Button();
            this.注册按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(156, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(198, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(206, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 2;
            // 
            // 教师登录
            // 
            this.教师登录.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.教师登录.Location = new System.Drawing.Point(105, 124);
            this.教师登录.Name = "教师登录";
            this.教师登录.Size = new System.Drawing.Size(115, 37);
            this.教师登录.TabIndex = 3;
            this.教师登录.TabStop = false;
            this.教师登录.Text = "教师登录";
            this.教师登录.UseVisualStyleBackColor = true;
            this.教师登录.Click += new System.EventHandler(this.教师登录_Click);
            // 
            // 学生登陆
            // 
            this.学生登陆.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学生登陆.Location = new System.Drawing.Point(105, 205);
            this.学生登陆.Name = "学生登陆";
            this.学生登陆.Size = new System.Drawing.Size(115, 37);
            this.学生登陆.TabIndex = 4;
            this.学生登陆.TabStop = false;
            this.学生登陆.Text = "学生登录";
            this.学生登陆.UseVisualStyleBackColor = true;
            this.学生登陆.Click += new System.EventHandler(this.学生登陆_Click);
            // 
            // root登录
            // 
            this.root登录.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.root登录.Location = new System.Drawing.Point(285, 124);
            this.root登录.Name = "root登录";
            this.root登录.Size = new System.Drawing.Size(115, 37);
            this.root登录.TabIndex = 5;
            this.root登录.TabStop = false;
            this.root登录.Text = "root登录";
            this.root登录.UseVisualStyleBackColor = true;
            this.root登录.Click += new System.EventHandler(this.root登录_Click);
            // 
            // 退出
            // 
            this.退出.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出.Location = new System.Drawing.Point(186, 297);
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(115, 31);
            this.退出.TabIndex = 6;
            this.退出.TabStop = false;
            this.退出.Text = "退出";
            this.退出.UseVisualStyleBackColor = true;
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // 注册按钮
            // 
            this.注册按钮.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注册按钮.Location = new System.Drawing.Point(285, 205);
            this.注册按钮.Name = "注册按钮";
            this.注册按钮.Size = new System.Drawing.Size(115, 37);
            this.注册按钮.TabIndex = 7;
            this.注册按钮.TabStop = false;
            this.注册按钮.Text = "注册";
            this.注册按钮.UseVisualStyleBackColor = true;
            this.注册按钮.Click += new System.EventHandler(this.注册按钮_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 382);
            this.Controls.Add(this.注册按钮);
            this.Controls.Add(this.退出);
            this.Controls.Add(this.root登录);
            this.Controls.Add(this.学生登陆);
            this.Controls.Add(this.教师登录);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "首页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button 教师登录;
        private System.Windows.Forms.Button 学生登陆;
        private System.Windows.Forms.Button root登录;
        private System.Windows.Forms.Button 退出;
        private System.Windows.Forms.Button 注册按钮;

    }
}

