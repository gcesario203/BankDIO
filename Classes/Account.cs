using System;
using System.Globalization;

namespace DIOBank
{
    public class Account
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double Credit { get; private set; }
        public AccountType AccountType { get; private set; }

        public Account(){}
        public Account(AccountType pAccountType, string pName, double pBalance, double pCredit)
        {
            this.AccountType = pAccountType;
            this.Balance = pBalance;
            this.Credit = pCredit;
            this.Name = pName;
        }

        private void ShowBalance(double pValue)
        {
            Console.WriteLine("{0}, your actual Balance is: {1}", this.Name, this.Balance.ToString("C",CultureInfo.GetCultureInfo("pt-BR")));
        }

        public bool Withdraw(double pValue)
        {
            if(this.Balance - pValue < (this.Credit * -1))
            {
                this.ErrorHandler(ErrorTypes.InsuficientBalance);

                return false;
            }

            this.Balance -= pValue;

            this.ShowBalance(pValue);
            return true;
        }

        public void Deposit(double pValue)
        {
            this.Balance += pValue;

            this.ShowBalance(pValue);
        }

        public void ErrorHandler(string pMessage)
        {
            Console.WriteLine("A error has been detected: {0}", pMessage);
        }
        public void Transfer(double pValue, Account pAccountDestiny)
        {
            if(this.Withdraw(pValue))
            {
                pAccountDestiny.Deposit(pValue);

                System.Console.WriteLine(this.ToString());
            }
            else
            {
                this.ErrorHandler(ErrorTypes.InsuficientBalance);
            }
        }

        public override string ToString()
        {
            var lReturnString = "";

            lReturnString += "Nome: "+ this.Name +"\n";
            lReturnString += "Tipo de conta: "+ this.AccountType +"\n";
            lReturnString += "Saldo: "+ this.Balance +"\n";
            lReturnString += "Crédito: "+ this.Credit +"\n";
            
            return lReturnString;
        }
    }
}