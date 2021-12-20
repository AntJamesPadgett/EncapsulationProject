using System;

namespace EncapsulationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var anthonysAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            anthonysAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank You!! Your balance is now {anthonysAccount.GetBalance()}");

           
        }
    }
}
