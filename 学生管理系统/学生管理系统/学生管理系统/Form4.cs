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
    
    public partial class Form4: Form
    {
        //private Data data = Data.getInstance();
        People people = null;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(People people)
        {
            InitializeComponent();

            this.people = people;

            if(people is Teacher)
            {
                Teacher teacher = (Teacher)people;
                Text = "欢迎" + teacher.getName() + "老师！";
                label6.Text = teacher.getID();
                label7.Text = teacher.getName();
                label8.Text = teacher.getAge().ToString();
                label9.Visible = false;
                label5.Visible = false;
                groupBox1.Visible = false;
            }
            else if(people is Student)
            {
                Student student = (Student)people;
                Text = "欢迎" + student.getName() + "同学！";
                label2.Text = "学号";
                label6.Text = student.getID();
                label7.Text = student.getName();
                label8.Text = student.getAge().ToString();
                label9.Text = student.getClass();
                管理班级ToolStripMenuItem.Visible = false;
                double ScoreCh = student.getChinese().getScore();
                double ScoreMa = student.getMathematics().getScore();
                double ScoreEn = student.getEnglish().getScore();
                textBox1.Text = ScoreCh.ToString();
                textBox2.Text = ScoreMa.ToString();
                textBox3.Text = ScoreEn.ToString();
                textBox4.Text = (ScoreCh + ScoreMa + ScoreEn).ToString();

            }
            else
            {

            }



        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 管理班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4_1((Teacher)people).ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 个人信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new Form3(people);
            form.Text = "账户";
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5(people).ShowDialog();
            this.Show();
        }
    }

    internal struct NewStruct
    {
        public object Item1;
        public object Item2;

        public NewStruct(object item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item2);
            return hashCode;
        }

        public void Deconstruct(out object item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
