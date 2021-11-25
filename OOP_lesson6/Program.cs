using System;

namespace OOP_lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount(50000, AccountType.Credit);
            BankAccount b2 = new BankAccount(50000, AccountType.Credit);
            BankAccount b3 = new BankAccount(AccountType.Checking);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b1 == b2);
            Console.WriteLine(b1 != b3);
        }
    }
}
