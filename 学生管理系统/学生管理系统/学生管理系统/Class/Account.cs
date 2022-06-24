namespace 学生管理系统 {

    public class Account
    {
        private string id;
        private string password;

        public Account(string id, string password)
        {
            this.id = id;
            this.password = password;
        }

        public string getId()
        {
            return id;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }

}
