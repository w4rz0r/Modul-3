namespace ATMClassesAndConstructor
{
    class PrintMethods
    {
        public void PrintLoginOptions()
        {
            Console.WriteLine("Welcome to DFAC");
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
        }


        public void PrintUser(string FirstName, string LastName)
        {
            Console.WriteLine("Welcome " + FirstName + " " + LastName + " what would you like to do?");
        }

        public void PrintLoggedInOptions()
        {
            Console.WriteLine("Please choose from one of the following options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Log out");
            Console.WriteLine("5. Exit");
        }
    }
}
