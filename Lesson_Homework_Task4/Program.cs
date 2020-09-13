using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Homework_Task4
{
    class Employee
    {
        public string name;
        public string lastName;
        public string possition;
        public int experience;

        public Employee (string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public void SalaryAndTaxes()
        {
            double  salary;
            double tax;
            switch(possition)
            {
                case "Бухгалтер":
                    {
                        if(experience<3)
                        {
                            int rate = 15000;
                            salary = rate - rate * 0.18;
                            tax = rate * 0.18;
                            Console.WriteLine("Заробітня плата після сплати податків складає {0} гривні(-ень), сума податків {1} гривні(-ень)", salary, tax);
                        }
                        else
                        {
                            int rate = 20000;
                            salary = rate - rate * 0.18;
                            tax = rate * 0.18;
                            Console.WriteLine("Заробітня плата після сплати податків складає {0} гривні(-ень), сума податків {1} гривні(-ень)", salary, tax);
                        }
                        break;
                    }
                case "Охоронець":
                    {
                        if (experience < 2)
                        {
                            int rate = 8000;
                            salary = rate - rate * 0.18;
                            tax = rate * 0.18;
                            Console.WriteLine("Заробітня плата після сплати податків складає {0} гривні(-ень), сума податків {1} гривні(-ень)", salary, tax);
                        }
                        else
                        {
                            int rate = 10500;
                            salary = rate - rate * 0.18;
                            tax = rate * 0.18;
                            Console.WriteLine("Заробітня плата після сплати податків складає {0} гривні(-ень), сума податків {1} гривні(-ень)", salary, tax);
                        }
                        break;
                    }
                case "Продавець":
                    {
                        if (experience < 2)
                        {
                            int rate = 10000;
                            salary = rate - rate * 0.18;
                            tax = rate * 0.18;
                            Console.WriteLine("Заробітня плата після сплати податків складає {0} гривні(-ень), сума податків {1} гривні(-ень)", salary, tax);
                        }
                        else
                        {
                            int rate = 13000;
                            salary = rate - rate * 0.18;
                            tax = rate * 0.18;
                            Console.WriteLine("Заробітня плата після сплати податків складає {0} гривні(-ень), сума податків {1} гривні(-ень)", salary, tax);
                        }
                        break;
                    }
            }
        }
    }
    class Program
    {
        /*
         * Завдання 4
        Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        Потрібно:
        Створити клас Employee.
        У тілі класу створити користувацький конструктор, який приймає два стрічкових аргументи, і ініціалізує поля, відповідно прізвище та імя співробітника.
        Створити метод, який розраховує оклад співробітника (в залежності від посади і стажу) і податкового збору.
        Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад і податковий збір.
        */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Employee worker = new Employee("Name", "Lastname");
            Console.WriteLine("Введіть ім'я працівника:");
            worker.name = Console.ReadLine();

            Console.WriteLine("Введіть прізвище працівника:");
            worker.lastName = Console.ReadLine();

            Console.WriteLine("Оберіть посаду працвника із запропонованих нижче:\nБухгалтер\nОхоронець\nПродавець\nВведіть посаду працівника:");
            worker.possition = Console.ReadLine();

            Console.WriteLine("Введіть стаж роботи працівника:");
            worker.experience = Int32.Parse(Console.ReadLine());

            worker.SalaryAndTaxes();


            Console.ReadKey();

        }
    }
}
