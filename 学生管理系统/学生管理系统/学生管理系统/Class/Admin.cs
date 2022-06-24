namespace 学生管理系统
{

    public class Admin
    {
        private Account account;

        public Admin() { }

        public Admin(string id, string password)
        {
            account = new Account(id, password);
        }

        public Data getData()
        {
            return Data.getInstance();
        }
    }
}
