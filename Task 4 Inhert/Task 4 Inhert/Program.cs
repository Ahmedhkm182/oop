namespace Task_4_Inhert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SavingAccount savingAcc = new SavingAccount("ISBN1001", "Ahmed hkm", 5000, 5);

            
            CurrentAccount currentAcc = new CurrentAccount("ISBN1002", "Omar hkm", 3000, 1000);

           
            List<BankAccount> accounts = new List<BankAccount>
            {
                savingAcc,
                currentAcc
            };

            
            foreach (var acc in accounts)
            {
                acc.ShowAccountDetails();
                Console.WriteLine($"Calculated Interest: {acc.CalculateInterest():C}");
                Console.WriteLine(new string('-', 40));
            }

            Console.ReadLine();
        }
    }
}
