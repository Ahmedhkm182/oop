using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Inhert
{
    class SavingAccount: BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string accountNumber, string holderName, decimal balance, decimal interestRate)
            : base(accountNumber, holderName, balance)
        {
            InterestRate = interestRate;
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }
}
