using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BankAccountApp;

namespace NunitBankAccountTestProject
{
    public class BankAccountTest
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(100);
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            // Act
            account.Deposit(50);

            // Assert
            Assert.That(150, Is.EqualTo(account.Balance));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            // Act
            account.Withdraw(40);

            // Assert
            Assert.That(60, Is.EqualTo(account.Balance));
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
        }

    }
}
