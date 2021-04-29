using System;

namespace DIOBank
{
    public static class BankMenu
    {
        public static string BuildMenu()
        {
            var lMenuKeys = Enum.GetNames(typeof(MenuOptions));

            IterateMenu(lMenuKeys);

            var lUserOption = Console.ReadLine().ToUpper();

            return lUserOption;
        }

        private static void IterateMenu(string[] pMenuKeys)
        {
            for(var i = 0;i<pMenuKeys.Length;i++)
            {
                var lCommand = (i+1).ToString();
                var lCommandName = pMenuKeys[i];
                WriteMenuLine(lCommand, lCommandName);
            }

            WriteMenuLine("C","Clean screen");
            WriteMenuLine("X","Exit");
        }

        private static void WriteMenuLine(string pCommand, string pCommandName)
        {
            Console.WriteLine("{0} - {1}", pCommand, pCommandName);
        }
    }
}