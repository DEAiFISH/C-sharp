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
    public partial class Form2 : Form
    {

        private Data data = Data.getInstance();
       

        public Form2()
        {
            InitializeComponent();
            
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 账号框_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void 密码框_TextChanged(object sender, EventArgs e)
        {

        }

        private void 登录按钮_Click(object sender, EventArgs e)
        {
            string id = 账号框.Text;
            string password = 密码框.Text;


            if(this.Text == "教师登录")
            {
                bool flag = true;
                foreach (var teacher in data.getTeachers())
                {
                    
                    if(password.Equals(teacher.Value.getAccount().getPassword()) &&  id.Equals(teacher.Value.getAccount().getId()))
                    {
                        /*
                         *  登录成功
                         */


                        this.Hide();
                        new Form4(teacher.Value).ShowDialog();
                        //new Form4(teacher.Value).Show();
                       
                        this.Close();
                        flag = false;
                        break;

                    }
                    
                }
                if (flag)
                {
                    MessageBox.Show("账号或密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    密码框.Text = "";
                }

            }
            else if(this.Text == "学生登录")
            {
                bool flag = true;
                foreach (var student in data.getStudents())
                {
                    

                    if (student.Value.getAccount().getId()==id && student.Value.getAccount().getPassword() == password)
                    {
                        /*
                         *  登录成功
                         */
                        
                        this.Hide();
                        new Form4(student.Value).ShowDialog();
                        this.Close();
                        flag = false;
                        break;

                    }

                }
                if (flag)
                {
                    MessageBox.Show("账号或密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    密码框.Text = "";
                }
            }
            else
            {
                if(id == "admin" && password == "admin")
                {
                    /*
                     *  登录成功
                     */
                    Form form = new Form6();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
