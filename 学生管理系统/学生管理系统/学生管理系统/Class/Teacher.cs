using System.Collections.Generic;

namespace 学生管理系统
{

    public class Teacher : People
    {
        private string ID;

        // private Class[] classes;
        private Dictionary<string, Class> classes = new Dictionary<string, Class>();
        private Account account;

        public Teacher(string ID, string name, int age, string id, string password) : base(name, age)
        {
            this.ID = ID;
            account = new Account(id, password);
        }
        public void setID(string ID)
        {
            this.ID = ID;
        }
        public string getID()
        {
            return ID;
        }

        public Dictionary<string,Class> getClasses()
        {

            return classes;
        }

        public bool addClass(Class c)
        {
            if (!classes.ContainsKey(c.getName()))
            {
                classes.Add(c.getName(), c);
                return true;
            }

            return false;
        }

        public bool deleteClassByName(string name)
        {
            return classes.Remove(name);
        }

        public Account getAccount()
        {
            return account;
        }

        public override string ToString()
        {
            string names = "";
            int i = 0;
            foreach (var @class in classes)
            {
                names += " " +　@class.Key;
                
            }

            return getID() + " " + getName() + " " + getAge() + " " + getAccount().getId() + " "
                   + getAccount().getPassword() + names;
        }
    }
}
