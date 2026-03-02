using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class SavingAccount:BankAccount
    {
        //public override void CalculateInterest(int x)
        //{

        //}
        //public SavingAccount(string name,string city,int age) { name = " jwlwef"; }
        public double interestRate=3.5;
        public double calculateInterest()
        {
            return (money*interestRate*1)/100;
        }
    }
}
