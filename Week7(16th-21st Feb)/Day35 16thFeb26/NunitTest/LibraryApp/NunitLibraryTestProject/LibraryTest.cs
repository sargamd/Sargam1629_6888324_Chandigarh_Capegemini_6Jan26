using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LibrarySystemApp;


namespace NunitLibraryTestProject
{
    public class LibraryTest
    {
        private Library lib;
        [SetUp]
        public void SetUp()
        {
            lib = new Library();
            lib.AddBook("C# basics", 2);
        }

        [Test]
        public void AddBook_NewBook_IncreaseCount()
        {
            //Arrange
            string title = "ASP.NET Core";
            int quantity = 3;

            //Act
            lib.AddBook(title, quantity);

            //Assert
            Assert.That(lib.GetBookCount(title), Is.EqualTo(3));
        }
        [Test]
        public void BorrowBook_ExistingBook_DecreasesCount()
        {
            //Arrange
            string title = "C# Basics";

            //Act
            lib.BorrowBook(title);

            //Assert
            Assert.That(lib.GetBookCount(title), Is.EqualTo(1));
        }
        [Test]
        public void BorrowBook_NotAvailable_ThrowsException()
        {
            //Arrange
            string title = "Java";

            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => lib.BorrowBook(title));

        }
    }
}
