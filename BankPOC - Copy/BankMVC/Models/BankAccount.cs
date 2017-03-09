using BankMVC.Models.Interfaces;
using System.Data.Entity;
using System;

namespace BankMVC.Models
{
    public enum AccountTypes
    {
        Checking,
        Saving
    }
    public class BankAccount : DbContext, IBankAccount
    {
        private float _accountBalance;
        private int _accountNumber;
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            private set {
                _accountNumber = new Random().Next();
            }
        }
        public float AccountBalance {
            get { return _accountBalance; }
        }

        public AccountTypes AccountType { get; set; }

        public int userid
        {
            get;
            set;
        }

        public BankAccount (AccountTypes accountType, int userid)
        {
            this.AccountNumber = new Random().Next(100, 200);
            this.AccountType = accountType;
            this.userid = userid;
        }
        
        public float GetAccountBalance(int accountNumber)
        {
            return this.AccountBalance;
        }

        public void Deposit(int accountNumber, float amount)
        {
            _accountBalance += amount;
        }

        public int GetAccountNumber(int userid)
        {
            return this.AccountNumber;
        }

        public void CreateAccount(int userid)
        {
            //need to break out of singleton to create a new account
        }
    }

    public abstract class BankDetails
    {
       public float processingTime;
      public virtual void ProcessDeposit()
        {
            //here is my virtual method implementation
        }
        public abstract void ProcessWithdraw();
    }

    public class WellsFargoBank : BankDetails
    {
        public string RoutingCode;
        public override void ProcessWithdraw()
        {
            base.processingTime += 1;
        }
        public override void ProcessDeposit()
        {
            //my own implementation 
        }
    }
}