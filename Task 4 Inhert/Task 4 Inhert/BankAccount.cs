using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Inhert
{
    class BankAccount
       {
       
            public string AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public decimal Balance { get; set; }

            public BankAccount(string accountNumber, string holderName, decimal balance)
            {
                AccountNumber = accountNumber;
                AccountHolderName = holderName;
                Balance = balance;
            }

            public virtual decimal CalculateInterest()
            {
                return 0;
            }

            public virtual void ShowAccountDetails()
            {
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Holder Name: {AccountHolderName}");
                Console.WriteLine($"Balance: {Balance:C}");
            }
        
       }
}
