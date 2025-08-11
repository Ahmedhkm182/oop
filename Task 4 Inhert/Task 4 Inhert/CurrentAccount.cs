using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Inhert
{
    class CurrentAccount: BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accountNumber, string holderName, decimal balance, decimal overdraftLimit)
            : base(accountNumber, holderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override decimal CalculateInterest()
        {
            return 0; 
        }

        public override void ShowAccountDetails()
        {
           
            base.ShowAccountDetails();
            
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit:C}");
        }
    }
}
