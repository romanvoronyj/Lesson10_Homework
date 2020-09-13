using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Homework_Task3
{
    class Converter
    {
        public double usd;
        public double eur;
        public double zlt;

        public Converter(double usd, double eur, double zlt)
        {
            this.usd = usd;
            this.eur = eur;
            this.zlt = zlt;
        }
        public void ConvertInUAH(double usd, double eur, double zlt)
        {
            Console.Write("Введіть суму, яку Ви бажаєте конвертувати у гривню: ");
            double value = Double.Parse(Console.ReadLine());
            Console.WriteLine("Доступні для конвертації валюти:\nUSD\nEUR\nZLT ");
            Console.Write("Введіть обрану валюту: ");
            string currency = Console.ReadLine();
            double amount = 0;

            switch (currency)
            {
                case "USD":
                    {
                        amount = value * usd;
                        Console.WriteLine("Сума у гривні складає: {0} гривні(-ень)", amount);
                        break;
                    }
                case "EUR":
                    {
                        amount = value * eur;
                        Console.WriteLine("Сума у гривні складає: {0} гривні(-ень)", amount);
                        break;
                    }

                case "ZLT":
                    {
                        amount = value * zlt;
                        Console.WriteLine("Сума у гривні складає: {0} гривні(-ень)", amount);
                        break;
                    }
            }
        }
        public void ConvertInForeignCurrency(double usd, double eur, double zlt)
        {
            Console.Write("Введіть суму у гривнях, яку Ви бажаєте конвертувати у іноземну валюту: ");
            double value = Double.Parse(Console.ReadLine());
            Console.WriteLine("Оберіть валюту, яку Ви бажаєте купити:\nUSD\nEUR\nZLT ");
            Console.Write("Введіть обрану валюту: ");
            string currency = Console.ReadLine();
            double amountForeign = 0;

            switch (currency)
            {
                case "USD":
                    {
                        amountForeign = value / usd;
                        Console.WriteLine("Сума у доларах складає:{0} долара(-ів)", amountForeign);
                        break;
                    }
                case "EUR":
                    {
                        amountForeign = value / eur;
                        Console.WriteLine("Сума у євро складає: {0} євро", amountForeign);
                        break;
                    }

                case "ZLT":
                    {
                        amountForeign = value / zlt;
                        Console.WriteLine("Сума у злотих складає: {0} злотих", amountForeign);
                        break;
                    }
            }

        }
    }
    class Program
    {
        /*Завдання 3
         Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
         Потрібно:
         Створити клас Converter.
         У тілі класу створити користувацький конструктор, який приймає три дійсних аргументи, і ініціалізує поля відповідного курсу 
         3-х основних валют, по відношенню до гривні - public Converter (double usd, double eur, double zlt).
         Написати програму, яка буде виконувати конвертацію з гривні в одну із зазначених валют, також програма має виробляти конвертацію з зазначених валютощлдюжж. в гривню.
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Converter myConvert = new Converter(27.8, 32.4, 7.38);
            myConvert.usd = 27.8;
            myConvert.eur = 32.4;
            myConvert.zlt = 7.38;
            myConvert.ConvertInUAH(myConvert.usd, myConvert.eur, myConvert.zlt);

            Console.WriteLine("Чи бажаєте Ви обміняти гривню на іноземну валюту?\nВведіть варіант YES або NO.");
            string agree = Console.ReadLine();

            if (agree == "YES")
            {
                myConvert.ConvertInForeignCurrency(myConvert.usd, myConvert.eur, myConvert.zlt);
            }
            else
            {
                Console.WriteLine("Дякуємо, до зустрічі!");
            }
            Console.ReadKey();
        }
    }
}
