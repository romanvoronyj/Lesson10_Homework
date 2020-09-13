using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Homework_Task5
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;

        private string article;
        private int quantity;
        

        public string SetArticle(string value)
        {
            article = value;
            return article;
        }
        public int SetQuantity(int value)
        {
            quantity = value;
            return quantity;
        }

        public Invoice(string account, string customer, string provider)
        {
            this.account = Int32.Parse(account);
            this.customer = customer;
            this.provider = provider;
        }

        public double TaxPay(double price, double tax, int quantity)
        {
            double amountWithTax = price * quantity * tax ;
            return amountWithTax;
        }
        public double WithoutTaxPay(double price, int quantity)
        {
            double amountWithoutTax = price * quantity;
            return amountWithoutTax;
        }


    }
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
     Потрібно:
     Створити клас Invoice.
     У тілі класу створити три поля int account, string customer, string provider які повинні бути проініціалізовані один раз 
     (при створенні екземпляра даного класу) без можливості їх подальшої зміни.
     У тілі класу створити два закритих поля string article, int quantity Створити метод розрахунку вартості замовлення з ПДВ і без ПДВ.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Invoice userInvoice = new Invoice("124", "Salam", "S-line");

            double price = 950;
            double tax = 1.2;
            Console.WriteLine("Доступна модель IPHONE 11 PRO MAX:\nwhite - ${0}\nДля вибору телефону білого кольору введіть артикул 2020.", price);
            Console.WriteLine("Введіть артикул товару: ");
            
            string phoneChoice = userInvoice.SetArticle(Console.ReadLine());

            Console.WriteLine("Введіть кількість товару:");
            int qty = userInvoice.SetQuantity(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Чи є Ви платником ПДВ?\nВведіть YES/NO");
            string custTax=Console.ReadLine();
            if(custTax == "YES")
            {
                double priceWithTax = userInvoice.TaxPay(price, tax, qty);
                Console.WriteLine("Сума до оплати з ПДВ складає: ${0}.",priceWithTax);

            }
            else if(custTax == "NO")
            {
                double priceWithoutTax = userInvoice.WithoutTaxPay(price, qty);
                Console.WriteLine("Сума до оплати без ПДВ складає: ${0}.", priceWithoutTax);
            }

            Console.ReadKey();


        }
    }
}
