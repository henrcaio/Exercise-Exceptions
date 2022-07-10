using System;
using ExerciseExceptions.Entities;
using ExerciseExceptions.Entities.Exceptions;

namespace ExerciseExceptions {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int accNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Console.Write("Enter withdraw amount: ");
            double amount = double.Parse(Console.ReadLine());

            Account acc = new Account(accNumber, holder, initialBalance, withdrawLimit);
            
            try {
                acc.Withdraw(amount);
                Console.WriteLine(acc.NewBalance());
            } catch (MoneyException e) {
                Console.WriteLine("Error! " + e.Message);
            }

        }
    }
}
