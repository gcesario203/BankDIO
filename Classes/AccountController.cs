using System;
using System.Collections.Generic;

namespace DIOBank
{
    public class AccountController
    {
        public List<Account> Accounts {get; private set;} = new List<Account>();

        public void InsertAccount(Account pAccount)
        {
            Accounts.Add(pAccount);
        
        }

        public void ListAccounts()
        {
            if(Accounts.Count > 0)
            {
                for(var i = 0 ;i<Accounts.Count;i++)
                {
                    System.Console.WriteLine(Accounts[i].ToString()); 
                }
            }
            else
            {
                System.Console.WriteLine("SEM ITENS");
            }
            
        }

        public void Transfer(string pObj)
        {
            var lStringArray = pObj.Split(",");

            var lAccountOrigin = this.GetAccountByIndex(int.Parse(lStringArray[0]));
            var lAccountDestiny = this.GetAccountByIndex(int.Parse(lStringArray[1]));

            lAccountOrigin.Transfer(double.Parse(lStringArray[2]), lAccountDestiny);
        }

        public Account GetAccountByIndex(int pIndex)
        {
            var lReturnAccount = new Account();

            for(var i = 0 ;i<Accounts.Count;i++)
            {
                if(i == pIndex)
                {
                    lReturnAccount = Accounts[i];
                }
            }

            return lReturnAccount;
        }

        public void Withdraw(string pObjString)
        {
            var lObj = pObjString.Split(",");

            var lAccount = this.GetAccountByIndex(int.Parse(lObj[0]));

            lAccount.Withdraw(double.Parse(lObj[1]));
        }

        public void Deposit(string pObjString)
        {
            var lObj = pObjString.Split(",");

            var lAccount = this.GetAccountByIndex(int.Parse(lObj[0]));

            lAccount.Deposit(double.Parse(lObj[1]));
        }
    }
}