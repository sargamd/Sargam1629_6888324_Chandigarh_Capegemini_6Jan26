using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankChatBot
{
    internal class BankOperation:IBankAccountOperation
    {
        private decimal balance = 0;

        public void Deposit(decimal d)
        {
            balance += d;
        }

        public void Withdraw(decimal d)
        {
            if (balance >= d)
                balance -= d;
        }

        public decimal ProcessOperation(string message)
        {
            message = message.ToLower();

            decimal amount = 0;

            Match m = Regex.Match(message, @"\d+");
            if (m.Success)
                amount = Convert.ToDecimal(m.Value);

            if (message.Contains("deposit") ||
                message.Contains("put") ||
                message.Contains("invest") ||
                message.Contains("transfer"))
            {
                Deposit(amount);
            }
            else if (message.Contains("withdraw") ||
                     message.Contains("pull"))
            {
                Withdraw(amount);
            }

            
            return balance;
        }
    }
}
