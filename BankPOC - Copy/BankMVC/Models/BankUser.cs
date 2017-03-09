using System;
using BankMVC.Models.Interfaces;
using System.Collections.Generic;

namespace BankMVC.Models
{
    public class BankUser :IBankUser
    {
        public BankUser()
        {
            //to avoid null ref excep for complex types
            bankAccounts = new List<IBankAccount>();
        }
        public int UserId { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public bool IsVip { get; set; }

        public List<IBankAccount> bankAccounts { get; set; }

        public BankUser AddUser(string username, string address)
        {
            BankUser user = new BankUser()
            {
                Address = address,
                FullName = username,
                IsVip = false,
                UserId = new Random().Next(500)
            };
            return user;
        }

        public void DeleteUser(int userid)
        {
            throw new NotImplementedException();
        }
        
        public void CreateBankAccount(BankAccount bankAccount, int userid)
        {
            bankAccounts.Add(new BankAccount(AccountTypes.Checking,userid));
        }

        public bool DeleteBankAccount(int accountNumber)
        {
            return bankAccounts.Remove(bankAccounts.Find(w=>w.AccountNumber == accountNumber));
        }

        public bool DepositMoney(int accountNumber, float amount)
        {
            if (amount > 10000)
                throw new Exception("Deposit amount cannot exceed $10,000.00");
            else
            {
                bankAccounts.Find(d => d.AccountNumber == accountNumber).Deposit(accountNumber, amount);
                return true;
            }
        }

        public bool WithdrawMoney(int accountNumber, float amount)
        {
            return true;
        }
    }
}