using System;

using System.Windows.Forms;


namespace 学生管理系统
{
    public partial class Form3 : Form
    {
        private Data data = Data.getInstance();
        private People people;
        public Form3()
        {
            InitializeComponent();
            
            button1.Visible = false;

            
        }

        public Form3(People people)
        {

            InitializeComponent();

            this.people = people;

            label1.Text = "修改密码";
            label2.Text = "旧密码";
            label3.Text = "新密码";
            教师注册按钮.Visible = false;
            学生注册按钮.Visible = false;
            button1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 教师注册按钮_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                var teachers = data.getTeachers();
                foreach(var teacher in teachers)
                {
                    if(id == teacher.Value.getID())
                    {
                        throw new MyException("该账号已被注册！！！");
                    }
                }



                Form form = new Form5(id, password, false);
                form.Text = "教师" + form.Text;
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message); 
                MessageBox.Show("该账号已被注册！", "提示！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void 学生注册按钮_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;




            try
            {
                var students = data.getStudents();
                foreach (var student in students)
                {
                    if (id == student.Value.getID())
                    {
                        throw new MyException("该账号已被注册！！！");
                    }

                    Form form = new Form5(id, password, true);
                    form.Text = "学生" + form.Text;

                    this.Hide();
                    form.ShowDialog();


                    this.Close();
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("该账号已被注册！", "提示！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

            string oldPassword = textBox1.Text;
            string newPassword = textBox2.Text;


            if (people is Student)
            {
                Student student = (Student)people;
                if (oldPassword == student.getAccount().getPassword())
                {
                    data.getStudents()[student.getName()].getAccount().setPassword(newPassword);
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("原密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Teacher teacher = (Teacher)people;
                if (oldPassword == teacher.getAccount().getPassword())
                {
                    data.getStudents()[teacher.getName()].getAccount().setPassword(newPassword);
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("原密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
