using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Form1 : Form
    {
        private Data data = Data.getInstance();
        public Form1()
        {
            InitializeComponent();
            new Form0().ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 教师登录_Click(object sender, EventArgs e)
        {
            /*
             * 点击教师登录
             */


            /*
             *  跳转到登录页面
             */

            Form form = new Form2();
            form.Text = "教师登录";
            this.Hide();
            form.ShowDialog();
            this.Show();

        }

        private void root登录_Click(object sender, EventArgs e)
        {
            /*
             * 点击root登录
             */


            /*
             *  跳转到登录页面
             */

            Form form = new Form2();
            form.Text = "管理员登录";
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void 学生登陆_Click(object sender, EventArgs e)
        {
            /*
             * 点击学生登录
             */


            /*
             *  跳转到登录页面
             */

            Form form = new Form2();
            form.Text = "学生登录";
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void 注册按钮_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            this.Hide();
            form.ShowDialog();
            Show();

        }

        private void 退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出？数据可能会丢失！", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (MessageBox.Show("           是否保存？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    data.saveData();
                    e.Cancel = false;     //关闭窗体
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;        //返回窗体
            }   
        }

    }
}
