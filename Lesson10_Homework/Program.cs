using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Homework
{
    class User
    {
        public string login;
        public string name;
        public string lastName;
        public int age;
        public readonly DateTime formingDate = DateTime.Now;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            User myAccount = new User();
            myAccount.login = "RM3";
            myAccount.name = "Roman";
            myAccount.lastName = "Voronyj";
            myAccount.age = 27;
            //myAccount.formingDate=1; Застосування модифікатора "readonly" дозволяє ініціалізувати поле лише 1 раз.
            Console.Write("Логін користувача:{0}\nІм'я користувача:{1}\nПрізвище користувача:{2}\nВік користувача:{3}\nДата заповенння анкети:{4}", myAccount.login, myAccount.name, myAccount.lastName, myAccount.age, myAccount.formingDate);
            Console.ReadKey();
        }
    }
}
