using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChatBot
{
    internal interface IBankAccountOperation
    {
        void Deposit(decimal d);
        void Withdraw(decimal d);
        decimal ProcessOperation(string message);
    }
}
