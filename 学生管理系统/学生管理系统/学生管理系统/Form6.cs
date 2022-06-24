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
    public partial class Form6 : Form
    {
        private Data data = Data.getInstance();
        public Form6()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
            textBox3.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;


            treeView1.Nodes.Clear();

            cleanSt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();

            textBox3.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;

            treeView1.Nodes.Clear();

            cleanTe();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                /*
                 *  获取名字
                 */
                string str = treeView1.SelectedNode.Text.Split(' ')[1];
                if (button1.BackColor.Name == "ControlDark")
                {
                    /*
                     *  管理学生
                     */
                    Student student = data.getStudents()[str];

                    textBox1.Text = student.getID();
                    textBox2.Text = student.getName();
                    textBox3.Text = student.getChinese().getScore().ToString();
                    textBox4.Text = student.getAccount().getId();
                    textBox5.Text = student.getAge().ToString();
                    textBox6.Text = student.getClass();
                    textBox7.Text = student.getMathematics().getScore().ToString();
                    textBox8.Text = student.getEnglish().getScore().ToString();
                    textBox9.Text = student.getAccount().getPassword();
                }
                else
                {
                    /*
                     *  管理教师
                     */

                    Teacher teacher = data.getTeachers()[str];

                    

                    textBox1.Text = teacher.getID();
                    textBox2.Text = teacher.getName();
                    textBox4.Text = teacher.getAccount().getId();
                    textBox5.Text = teacher.getAge().ToString();
                    textBox9.Text = teacher.getAccount().getPassword();

                    var _class = teacher.getClasses();
                    string strs = "";
                    foreach(var c in _class)
                    {
                        strs += c.Key;
                    }
                    textBox6.Text = strs;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                /*
                 *  获取名字
                 */
                string str = treeView1.SelectedNode.Text.Split(' ')[1];
                if (button1.BackColor.Name == "ControlDark")
                {
                    /*
                     *  删除学生
                     */

                    if (MessageBox.Show("是否要删除？删除后将不能恢复！！！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        data.getStudents().Remove(str);
                        cleanSt();

                    }

                    
                }
                else
                {
                    /*
                     *  管理教师
                     */

                    if (MessageBox.Show("是否要删除？删除后将不能恢复！！！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        data.getTeachers().Remove(str);
                        cleanSt();

                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
            if(button1.BackColor.Name == "ControlDark")
            {
                //正在查看学生
                cleanSt();
            }
            else
            {
                cleanTe();
            }
            this.Show();
        }

        public void cleanSt()
        {
            //学生treeView刷新
            treeView1.Nodes.Clear();

            button2.BackColor = SystemColors.Control;
            button1.BackColor = SystemColors.ControlDark;
            var students = data.getStudents();
            foreach (var student in students)
            {
                treeView1.Nodes.Add(student.Value.ToString());
            }
        }

        public void cleanTe()
        {
            treeView1.Nodes.Clear();
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.ControlDark;

            var teachers = data.getTeachers();
            foreach (var teacher in teachers)
            {
                treeView1.Nodes.Add(teacher.Value.ToString());
            }
        }

        public void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = ""; 
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.BackColor.Name == "ControlDark")
            {
                //正在查看学生


                string ID = textBox1.Text;
                string name = textBox2.Text;
                string ch = textBox3.Text;
                string id = textBox4.Text;
                string age = textBox5.Text;
                string _class = textBox6.Text;
                string Ma = textBox7.Text;
                string En = textBox8.Text;
                string password = textBox9.Text;

                data.getStudents()[name] = new Student(ID, name, int.Parse(age), _class, id, password, 
                    double.Parse(ch), double.Parse(En), double.Parse(Ma));

                cleanSt();
            }
            else
            {

                string ID = textBox1.Text;
                string name = textBox2.Text;
                string id = textBox4.Text;
                string age = textBox5.Text;
                string _class = textBox6.Text;
                string password = textBox9.Text;

                try
                {
                    Teacher teacher = new Teacher(ID, name, int.Parse(age), id, password);
                    string[] classes = _class.Trim().Split(' ');
                    foreach (string cls in classes)
                    {
                        teacher.addClass(data.getClass()[cls]);
                    }
                    data.getTeachers()[name] = teacher;

                    cleanTe();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("年龄请输入纯数字！");

                    MessageBox.Show("年龄请输入纯数字！", "提示！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
