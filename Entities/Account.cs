using System;
using ExerciseExceptions.Entities.Exceptions;
using System.Text;

namespace ExerciseExceptions.Entities {
    class Account {
        public int AccNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int accNumber, string holder, double balance, double withdrawLimit) {
            AccNumber = accNumber;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double dep) {
            Balance += dep;
        }

        public void Withdraw(double amount) {
            if (Balance < amount) {
                throw new MoneyException("There's not enough money to be withdrawn");
            } else if (amount > WithdrawLimit) {
                throw new MoneyException("The amount requested exceeds the withdraw limit available");
            } else {
                Balance -= amount;
            }
        }

        public string NewBalance() {
            return "\nNew balance: US$"
                + Balance;
        }
    }
}
