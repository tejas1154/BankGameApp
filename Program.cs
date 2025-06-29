namespace BankAccountGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of 1st account holder: ");
            string name1 = Console.ReadLine();

            Console.Write($"Enter starting balance for {name1}: ");
            double balance1 = double.Parse(Console.ReadLine());

            Console.Write("Enter name of 2nd account holder: ");
            string name2 = Console.ReadLine();

            Console.Write($"Enter starting balance for {name2}: ");
            double balance2 = double.Parse(Console.ReadLine());

            BankAccount account1 = new BankAccount(name1, balance1);
            BankAccount account2 = new BankAccount(name2, balance2);

            for(int i=1; i<=3; i++)
            {
                Console.WriteLine($"\n Round {i}");

                //Account 1 turn
                Console.Write($"{name1} Withdraw or Deposit (w/d): ");
                string choice1 = Console.ReadLine();

                if (choice1 == "w")
                {
                    Console.Write("Amount to withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    account1.Withdraw(amount);
                }
                else if (choice1 == "d")
                {
                    Console.Write("Amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    account1.Deposit(amount);
                }
                else
                    Console.WriteLine("Invalid Choice. Skipping Turn");

                //Account 2 turn
                Console.Write($"{name2} Withdraw or Deposit (w/d): ");
                string choice2 = Console.ReadLine();

                if (choice2 == "w")
                {
                    Console.Write("Amount to withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    account2.Withdraw(amount);
                }
                else if (choice2 == "d")
                {
                    Console.Write("Amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    account2.Deposit(amount);
                }
                else
                    Console.WriteLine("Invalid Choice. Skipping Turn");
            }

            Console.WriteLine("\nFinal Balance");
            Console.WriteLine($"{account1.AccountHolder}: {account1.Balance}");
            Console.WriteLine($"{account2.AccountHolder}: {account2.Balance}");

            Console.WriteLine("\nWinner- ");
            if (account1.Balance > account2.Balance)
                Console.WriteLine($"{account1.AccountHolder} wins");
            else if (account1.Balance < account2.Balance)
                Console.WriteLine($"{account2.AccountHolder} wins");
            else
                Console.WriteLine("Its a tie");
        }
    }
}
