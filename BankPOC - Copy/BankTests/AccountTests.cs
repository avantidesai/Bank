using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentAssertions;
using BankMVC.Models.Interfaces;
using BankMVC.Models;

namespace BankTests
{
    [TestClass]
    public class AccountTests
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //do init stuff here
        }

        [TestInitialize]
        public void Init()
        {
            //do test init stuff here
        }
               
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IBankAccount> ib = new Mock<IBankAccount>();
            Mock<IBankUser> iu = new Mock<IBankUser>();
            
            iu.Should().NotBeNull();

            //Tuple<string, string> userData = GetUserData(2);
            //Action<int> action = new Action<int>(Sum);
            //Func<int, int> actionFunc = new Func<int, int>(Subtract);
            //Predicate<int?> actionPredicate = new Predicate<int?>(Check);

            var customer = new BankUser().AddUser("avanti","NYC");
            customer.CreateBankAccount(new BankAccount(AccountTypes.Checking,customer.UserId));
            customer.DepositMoney(customer.bankAccounts[0].AccountNumber, 100);

            var balance = customer.bankAccounts[0].GetAccountBalance(customer.bankAccounts[0].AccountNumber);
          

        }

        private bool Check(int? obj)
        {
            return obj.HasValue;
        }

        private int Subtract(int arg)
        {
            return arg + 2;
        }

        private void Sum(int obj)
        {
            var result = obj + 2;
        }

        private Tuple<string, string> GetUserData(int userId)
        {
            return new Tuple<string, string>("avanti", "adu");
            
        }
    }

}
