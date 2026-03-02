using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class BankAccount
    {
        public string name{  get; set; }
        public static int accno = 100;
        public int age{ get; set; }
        public string city{  get; set; }
        public int money { get; set; }
        //public float interest {  get; set; }
        public BankAccount()
        {
            Console.WriteLine("Enter Details: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("City: ");
            city = Console.ReadLine();
            accno++;
            Console.WriteLine("Account Created!");
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("City: " + city);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Account Number: " + accno);

            //this.money = money;
            //this.interest = interest;
        }
        public void Deposit(int x)
        {
            money = money + x;
            Console.WriteLine("Money Deposited!");

        }
        public void Withdraw(int x)
        {
            if (money < x)
            {
                Console.WriteLine("Insufficient Balance");
                return;
            }
            money=money-x;
            Console.Write("Money debited!");
        }
        public void Display()
        {
            Console.WriteLine("Accout Summary: ");
            Console.WriteLine("Account Number: " + accno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Balance: "+money);
            
        }

        //public virtual  void CalculateInterest(int x)
        //{
        //    x = money;
        //}
    }
}
