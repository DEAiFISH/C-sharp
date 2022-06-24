using System;

namespace 学生管理系统
{

    public class Student : People
    {
        private string ID;
        private Course Chinese;
        private Course Mathematics;
        private Course English;
        private string _class;
        private Account account;
        

        public Student(string ID, string name, int age, string _class, string id, string password) : base(name, age)
        {
            this.ID = ID;
            this._class = _class;
            Class @class = null;
            Data data = Data.getInstance();

            if(!data.getClass().TryGetValue(_class,out @class))
            {
                data.getClass().Add(_class,new Class(_class));
            }

            /*
             *  初始化成绩   
             */
            Chinese = new Course(-1);
            Mathematics = new Course(-1);
            English = new Course(-1);

            /*
             *  创建一个新账户
             */
            account = new Account(id, password);
        }

        public Student(string ID, string name, int age, string _class, string id, string password, double scoreCh,
            double scoreEn, double scoreMa) : base(name, age)
        {
            this.ID = ID;
            Chinese = new Course(scoreCh);
            Mathematics = new Course(scoreMa);
            English = new Course(scoreEn);
            this._class = _class;
            account = new Account(id, password);

            
        }

        public string getID()
        {
            return ID;
        }
        public void setID(string ID)
        {
            this.ID=ID;
        }
        public Course getChinese()
        {
            return Chinese;
        }

        public Course getEnglish()
        {
            return English;
        }

        public Course getMathematics()
        {
            return Mathematics;
        }

        public string getClass()
        {
            return _class;
        }

        public void setClass(string _class)
        {
            this._class = _class;
        }

        public Account getAccount()
        {
            return account;
        }

        public override string ToString()
        {
            return getID() + " " + getName() + " " + getAge() + " " + _class + " " + getAccount().getId() + " "
                   + getAccount().getPassword() + " " + getChinese().getScore() + " " +
                   getMathematics().getScore() + " " + getEnglish().getScore();
        }

        public string _ToString()
        {
            return getName() + "\t" + "  " + getChinese().getScore() + "\t" +
                   getMathematics().getScore() + "\t" + getEnglish().getScore() +　"\t" + getID();
        }
    }
}
