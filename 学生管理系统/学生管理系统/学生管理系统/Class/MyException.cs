using System;
namespace 学生管理系统 { 
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
