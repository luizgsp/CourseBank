using System;
using Banco.Entity.Exceptions;

namespace Banco.Entity
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            if (ammount > Balance)
                throw new DomainException("Saque inválido! Valor do saque maior"
                    +" que o saldo em conta!");
            if(ammount > WithdrawLimit)
                throw new DomainException("Saque inválido! Valor do saque maior"
                    + " que o limite de saque da conta!");


            Balance -= ammount;
        }
    }
}
