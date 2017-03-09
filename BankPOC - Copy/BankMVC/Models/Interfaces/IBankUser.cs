using System.Collections.Generic;

namespace BankMVC.Models.Interfaces
{
    public interface IBankUser
    {
         int UserId { get; set; }

         string FullName { get; set; }

         string Address { get; set; }

         bool IsVip { get; set; }
        List<IBankAccount> bankAccounts { get; set; }
        BankUser AddUser(string username, string address);
        void DeleteUser(int userid);

        void CreateBankAccount(BankAccount bankAccount,int userid);

        bool DeleteBankAccount(int accountNumber);

        bool DepositMoney(int accountNumber, float amount);

        bool WithdrawMoney(int accountNumber, float amount);
    }

}
