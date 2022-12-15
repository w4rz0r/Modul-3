namespace ATMClassesAndConstructor
{
    internal class OptionExecuters
    {
        public CardHolder CurrentUser { get; set; }
        public Login Login { get; set; }
        public PrintMethods Print { get; set; }
        public Bank Bank { get; set; }


        public OptionMethods Option = new OptionMethods();
        public int option = 0;


        public void ExecuteLoginOptions()
        {
            var login = new Login();
            Print = new PrintMethods();
            do
            {
                Print.PrintLoginOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Login Failed!"); break; }
                if (option == 1) { login.FindUser(); }
                else if (option == 2) { Bank.AddNewCustomer(); }
                else if (option == 3) { Console.WriteLine("Thank you! Have a nice day!"); Environment.Exit(0); }
            }
            while (option != 4);
        }

        public void ExecuteLoggedInOptions()
        {
            var login = new Login();
            Print = new PrintMethods();
            do
            {
                Print.PrintLoggedInOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("User Options Failed!"); break; }
                if (option == 1) { Option.Deposit(CurrentUser); }
                else if (option == 2) { Option.Withdraw(CurrentUser); }
                else if (option == 3) { Option.Balance(CurrentUser); }
                else if (option == 4) { Login.FindUser(); }
                else if (option == 5) { Console.WriteLine("Thank you! Have a nice day!"); Environment.Exit(0); }
            }
            while(option != 6);
        }
    }
}
