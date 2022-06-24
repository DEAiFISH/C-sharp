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
    public partial class Form5 : Form
    {
        private Data data = Data.getInstance();
        private string id;
        private string password;
        private People people;
        /*
         *  true 为学生
         */
        private bool flag = false;
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(People people)
        {
            InitializeComponent();
            this.people = people;

            button1.Text = "完成";
        }

        public Form5(string id, string password,bool flag)
        {
            InitializeComponent();

            this.id = id;  
            this.password = password;
            this.flag = flag;
            if (flag)
            {
                label4.Text = "    学号:";
            }
            else
            {
                label5.Visible = false;
                班级.Visible = false;
            }
        }
        

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void 班级_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = 姓名.Text;
            string age = 年龄.Text;
            string _class = 班级.Text;
            string ID = 工号.Text;



            //防止**
            try
            {
                if (people == null)
                {
                    //用户界面进入注册

                    if (flag)
                    {
                        data.getStudents().Add(name, new Student(ID, name, int.Parse(age), _class, id, password));
                    }
                    else
                    {
                        data.getTeachers().Add(name, new Teacher(ID, name, int.Parse(age), id, password));
                    }
                }
                else
                {

                    //root界面进入注册
                    if (people is Student)
                    {
                        data.getStudents()[people.getName()].setName(name);
                        data.getStudents()[people.getName()].setAge(int.Parse(age));
                        data.getStudents()[people.getName()].setClass(_class);
                        data.getStudents()[people.getName()].setID(ID);

                    }
                    else
                    {
                        data.getTeachers()[people.getName()].setName(name);
                        data.getTeachers()[people.getName()].setAge(int.Parse(age));
                        data.getTeachers()[people.getName()].setID(ID);
                    }
                }


                this.Close();


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);  
                Console.WriteLine("年龄请输入纯数字！");

                MessageBox.Show("年龄请输入纯数字！", "提示！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("该用户已经被添加！");

                MessageBox.Show("该用户已经被添加！", "提示！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void 工号_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
