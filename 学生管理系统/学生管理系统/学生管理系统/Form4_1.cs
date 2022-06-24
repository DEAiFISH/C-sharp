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
    public partial class Form4_1 : Form
    {
        private Data data = Data.getInstance();
        private Teacher teacher;
        /*
         *  保存选中的节点名字
         */
        private string str;
        public Form4_1()
        {
            InitializeComponent();
        }

        public Form4_1(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            Dictionary<string, Class> classes = teacher.getClasses();
            groupBox1.Visible = false;
            int i = 0;

            管理班级ToolStripMenuItem.Enabled = false; 
            /*
             * 添加班级节点
             */
            foreach (var _class in classes)
            {
                
                treeView1.Nodes.Add(_class.Key);
                Class c = _class.Value;

                /*
                 *  添加学生节点
                 */
                foreach (var student in c.getAllStudents())
                {
                    if (student.Value.getClass().Equals(_class.Key))
                    {
                        treeView1.Nodes[i].Nodes.Add(student.Key);
                    }
                }
                i++;
            }

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void 账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form3(teacher);
            form.Text = "账户";
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            str = e.Node.Text;
            TreeNode tn = treeView1.SelectedNode;
            if (tn == null)
                return;
            if (tn.Level == 0)
            {
                listBox1.Items.Clear();
                groupBox1.Visible = false;
                listBox1.Visible = true;
                Class _class = teacher.getClasses()[tn.Text];
                double[] strs = teacher.getClasses()[tn.Text].showAverages();
                listBox1.Items.Add("平均成绩：");
                listBox1.Items.Add("语文：" + strs[0] + "    数学：" + strs[1] + "    英语：" + strs[2]);
                listBox1.Items.Add("");
                listBox1.Items.Add("方差：");
                strs = teacher.getClasses()[tn.Text].showVariance();
                listBox1.Items.Add("语文：" + strs[0] + "    数学：" + strs[1] + "    英语：" + strs[2]);
                listBox1.Items.Add("");
                strs = teacher.getClasses()[tn.Text].showRange();
                listBox1.Items.Add("极差：");
                listBox1.Items.Add("语文：" + strs[0] + "    数学：" + strs[1] + "    英语：" + strs[2]);
                listBox1.Items.Add("");

                listBox1.Items.Add("--------------学生成绩表---------------");
                listBox1.Items.Add("姓名\t语文\t数学\t英语\t学号");

                foreach (var studet in _class.getAllStudents())
                {
                   
                    listBox1.Items.Add(studet.Value._ToString());
                }
            }
            else if(tn.Level == 1)
            {
                groupBox1.Visible = true;
                listBox1.Visible = false;
                Student student = data.getStudents()[tn.Text];
                textBox1.Text = student.getName();
                textBox2.Text = student.getID();
                textBox3.Text = student.getAge().ToString();
                textBox4.Text = student.getChinese().getScore().ToString();
                textBox5.Text = student.getMathematics().getScore().ToString();
                textBox6.Text = student.getEnglish().getScore().ToString();
            }


        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "编辑")
            {
                textBox1.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                button1.Text = "保存";
            }
            else
            {
                textBox1.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                button1.Text = "编辑";

                string name = textBox1.Text;
                string age = textBox3.Text;
                string ScoreCh = textBox4.Text;
                string ScoreMa = textBox5.Text;
                string ScoreEn = textBox6.Text;

                try
                {
                    data.getStudents()[str].setAge(int.Parse(age));
                    data.getStudents()[str].getChinese().setScore(double.Parse(ScoreCh));
                    data.getStudents()[str].getMathematics().setScore(double.Parse(ScoreMa));
                    data.getStudents()[str].getEnglish().setScore(double.Parse(ScoreEn));
                    data.getStudents()[str].setName(name);
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("年龄请输入纯数字！");

                    MessageBox.Show("年龄请输入纯数字！", "提示！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
        }

        private void 管理班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5(teacher).ShowDialog();
            this.Show();
        }
    }
}
