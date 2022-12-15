namespace ATMClassesAndConstructor
{
    internal class Login
    {
        public CardHolder CurrentUser { get; set; }
        public Bank Bank = new Bank();
        public PrintMethods Print = new PrintMethods();
        public OptionExecuters execute = new OptionExecuters();



        public void FindUser()
        {
            while (true)
            {
                Console.WriteLine("Please Enter Your Card Number!");
                try
                {
                    string debitCardNum = Console.ReadLine();
                    CurrentUser = Bank.CardHolders.FirstOrDefault(user => user.CardNum == debitCardNum);
                    if (CurrentUser != null) { CheckPin(); }
                    else { Console.WriteLine("Card not recognized. Please try again! "); }
                }
                catch { Console.WriteLine("Card Number Failed!"); }
            }
        }

        void CheckPin()
        {
            Console.WriteLine("Please enter your pin: ");
            while (true)
            {
                try
                {
                    var userPin = int.Parse(Console.ReadLine());
                    if (CurrentUser.Pin == userPin) { Print.PrintUser(CurrentUser.FirstName, CurrentUser.LastName); execute.ExecuteLoggedInOptions(); }
                    else { Console.WriteLine("Incorrect pin. please try again!"); }
                }
                catch { Console.WriteLine("Pin Failed!"); }
            }
        }
    }
}
