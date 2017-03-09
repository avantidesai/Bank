using System;

namespace BankMVC.Models.Interfaces
{
 
    public interface IBankAccount 
    {
        int userid { get; set; }
        int AccountNumber { get; }
         float AccountBalance { get;}
        
        AccountTypes AccountType { get; set; }

        float GetAccountBalance(int accountNumber);
        void Deposit(int accountNumber, float amount);
        int GetAccountNumber(int userid);

        void CreateAccount(int userid);
    }
}
 