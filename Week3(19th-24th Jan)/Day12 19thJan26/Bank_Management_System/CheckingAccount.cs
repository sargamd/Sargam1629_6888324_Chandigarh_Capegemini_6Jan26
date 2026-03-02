using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class CheckingAccount:BankAccount
    {
        public double interestRate = 2.5;
        public double calculateInterest()
        {
            money = money + (money * interestRate * 1) / 100;
            return (money * interestRate * 1) / 100;
        }
    }
}
