using System;

namespace DIOBank
{
    public class Application
    {
        public AccountController AccountController {get;set;}
        public UserInterface UserInterface {get;set;}

        public void Init()
        {
            this.AccountController = new AccountController();
            this.UserInterface = new UserInterface();

            lUserOptions();
        }

        public void lUserOptions()
        {
            var pUserOption = BankMenu.BuildMenu();
            while(pUserOption != "X")
            {
                switch(pUserOption)
                {
                    case "1":
                        AccountController.ListAccounts();
                        pUserOption = BankMenu.BuildMenu();
                        break;
                    case "2":
                        var lAccount = UserInterface.InsertAccount();
                        AccountController.InsertAccount(lAccount);
                        pUserOption = BankMenu.BuildMenu();
                        break;
                    case "3":
                        var lObjString = UserInterface.TransferInterface(this.AccountController.Accounts.Count);
                        if(lObjString == "0")
                        {
                            System.Console.WriteLine("IMPOSSIVEL REALIZAR OPERAÇÃO");
                        }
                        else
                        {
                            AccountController.Transfer(lObjString);
                        }
                        
                        pUserOption = BankMenu.BuildMenu();
                        break;
                    case "4":
                        var lWithdrawString = UserInterface.Withdraw(this.AccountController.Accounts.Count);
                        AccountController.Withdraw(lWithdrawString);
                        pUserOption = BankMenu.BuildMenu();
                        break;
                    case "5":
                        var lDepositString = UserInterface.Deposit(this.AccountController.Accounts.Count);
                        AccountController.Deposit(lDepositString);
                        pUserOption = BankMenu.BuildMenu();
                        break;
                    case "C":
                        Console.Clear();
                        pUserOption = BankMenu.BuildMenu();
                        break;
                }
            }
        }
    }
}