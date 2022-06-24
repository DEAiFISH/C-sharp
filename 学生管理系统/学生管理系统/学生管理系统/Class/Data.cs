using System;
using System.Collections.Generic;
using System.IO;

namespace 学生管理系统
{
    public class Data
    {
        private IDictionary<string, Teacher> teachers = new Dictionary<string, Teacher>();
        private IDictionary<string, Student> students = new Dictionary<string, Student>();
        private IDictionary<string, Class> classes = new Dictionary<string, Class>();
        private static Data Instance = null;


        public static Data getInstance()
        {
            if (Instance == null)
            {
                Instance = new Data();
            }

            return Instance;
        }

        /**
         *  静态代码块
         *
         *  将所有数据读取到内存中
         */
        private Data()
        {
            // 创建一个 StreamReader 的实例来读取文件 
            StreamReader sr = null;
            try
            {

                /*
                 *  获取执行文件路径
                 * string str = System.Environment.CurrentDirectory;
                 */
                /*
                 *  拿到了所有学生信息S
                 */
                FileInfo file = new FileInfo(@"../../Data/Student/student.txt");
                sr = new StreamReader(file.FullName);

                string line;
                string[] student;

                while ((line = sr.ReadLine()) != null)
                {
                    student = line.Trim().Split(' ');
                    students.Add(student[1],
                        new Student(student[0],student[1],int.Parse(student[2]),student[3],student[4],student[5],double.Parse(student[6]),double.Parse(student[7]),double.Parse(student[8])));
                }
                sr.Close();


                /*
                 *  获取所有班级信息
                 */
                FileInfo[] files = new DirectoryInfo(@"../../Data/Class").GetFiles();

                foreach (FileInfo fileInfo in files)
                {
                    sr = new StreamReader(fileInfo.FullName);
                    string fileName = fileInfo.Name;
                    Class _class = new Class(fileName.Substring(0, fileName.Length - 4));


                    while ((line = sr.ReadLine()) != null)
                    {
                        Student s = students[line];
                        _class.addStudent(s);
                    }

                    string className = fileName.Substring(0, fileName.Length - 4);
                    classes.Add(className, _class);
                    sr.Close();

                }


                /*
                 *  获取所有老师信息
                 */
                file = new FileInfo(@"../../Data/Teacher/teacher.txt");

                // 创建一个 StreamReader 的实例来读取文件 
                sr = new StreamReader(file.FullName);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] teacher = line.Split(' ');
                    Teacher t = new Teacher(teacher[0], teacher[1], int.Parse(teacher[2]), teacher[3], teacher[4]);

                    if (teacher.Length > 5)
                    {
                        for (int i = 5; i < teacher.Length; i++)
                        {
                            t.addClass(classes[teacher[i]]);
                        }
                    }

                    teachers.Add(teacher[1], t);
                }

                sr.Close();
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public void saveData()
        {
            StreamWriter sw = null;


            try
            {
                /*
             *  保存学生信息
             */
                FileInfo file = new FileInfo(@"../../Data/Student/student.txt");
                sw = new StreamWriter(file.FullName);

                foreach (var item in students)
                {
                    sw.WriteLine(item.Value.ToString());
                }
                sw.Close();


                /*
             *  保存班级信息
             */
                FileInfo[] files = new DirectoryInfo(@"../../Data/Class").GetFiles();
                foreach (var _class in classes)
                {
                    bool flag = true;
                    foreach (var fileInfo in files)
                    {
                        if (fileInfo.Name == _class.Key + ".txt")
                        {
                            sw = new StreamWriter(fileInfo.FullName);
                            
                            Dictionary<string,Student> allStudents = _class.Value.getAllStudents();
                            foreach (var s in allStudents)
                            {
                                sw.WriteLine(s.Key);
                            }
                            sw.Close();
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        string path = "../../Data/Class/" + _class.Key + ".txt";
                        sw = new StreamWriter(path);
                        
                        Dictionary<string,Student> allStudents = _class.Value.getAllStudents();
                        foreach (var s in allStudents)
                        {
                            sw.WriteLine(s.Key);
                        }
                        sw.Close();
                        
                    }
                }
                
                
                /*
             *  保存教师信息
             */

                file = new FileInfo(@"../../Data/Teacher/teacher.txt");
                sw = new StreamWriter(file.FullName);
                foreach (var item in teachers)
                {
                    sw.WriteLine(item.Value.ToString());
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }


        public Dictionary<string, Student> getStudents()
        {
            return (Dictionary<string, Student>) students;
        }

        public Dictionary<string, Teacher> getTeachers()
        {
            return (Dictionary<string, Teacher>) teachers;
        }

        public Dictionary<string, Class> getClass()
        {
            return (Dictionary<string, Class>) classes;
        }
    }
}