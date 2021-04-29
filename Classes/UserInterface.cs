using System;

namespace DIOBank
{
    public class UserInterface
    {
        public Account InsertAccount()
        {
            System.Console.WriteLine("Tipo de conta: 1 para pessoa fisica e 2 para pessoa jurídica");
            var lAccountType = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Nome do usuário");
            var lName = Console.ReadLine();
            System.Console.WriteLine("Saldo");
            var lBalance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Crédito");
            var lCredit = double.Parse(Console.ReadLine());

            return new Account(
                lAccountType == 1 ? AccountType.PhisicalPerson : AccountType.JuridicPerson,
                lName,
                lBalance,
                lCredit
            );
        }

        public string TransferInterface(int pAccountTotal)
        {
            System.Console.WriteLine(pAccountTotal);
            if(pAccountTotal >= 2)
            {
                System.Console.WriteLine("Digite o índice da conta que fará a transferencia de 0 - {0}", (pAccountTotal-1).ToString());
                var lIndexOrigin = Console.ReadLine();
                System.Console.WriteLine("Digite o índice da conta que receberá a transferencia de 0 - {0}", (pAccountTotal-1).ToString());
                var lIndexDestiny = Console.ReadLine();
                System.Console.WriteLine("Digite o valor");
                var lValue = Console.ReadLine();

                var lString = lIndexOrigin + "," + lIndexDestiny + "," + lValue;

                return lString;
            }
            else
            {
                return "0";
            }
        }

        public string Withdraw(int pAccountTotal)
        {
            System.Console.WriteLine("Digite o índice da conta que será feito o saque 0 - {0}", (pAccountTotal-1).ToString());
            var lAccountIndex = Console.ReadLine();
            System.Console.WriteLine("Digite o valor");
            var lValue = Console.ReadLine();

            return lAccountIndex + "," + lValue;
        }

        public string Deposit(int pAccountTotal)
        {
            System.Console.WriteLine("Digite o índice da conta que será feito o deposito 0 - {0}", (pAccountTotal-1).ToString());
            var lAccountIndex = Console.ReadLine();
            System.Console.WriteLine("Digite o valor");
            var lValue = Console.ReadLine();

            return lAccountIndex + "," + lValue;
        }
    }
}