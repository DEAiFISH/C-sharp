// See https://aka.ms/new-console-template for more information

namespace 学生管理系统
{

    public class People
    {
        private string name;
        private int age;

        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public People(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
