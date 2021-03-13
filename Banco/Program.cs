using System;
using System.Globalization;
using Banco.Entity;
using Banco.Entity.Exceptions;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("BANCO DA TERRA ===============================");
                Console.WriteLine("Entre com os dados da Conta");
                Console.Write("Numero...........:");
                int numAccount = int.Parse(Console.ReadLine());
                Console.Write("Correntista......:");
                string holderAccount = Console.ReadLine();
                Console.Write("Saldo Inicial....:");
                double balanceAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de Saque..:");
                double withdrawAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(numAccount, holderAccount, balanceAccount, withdrawAccount);

                Console.WriteLine();
                Console.Write("Informe o valor para Saque: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw);

                Console.Write("Novo Saldo: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine("Atenção: " + e.Message);
            }
        }
    }
}
