namespace ATMClassesAndConstructor
{
    static class CreateNewUser
    {
        public static string CheckNewCardNum()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a card number!");
                    string newCardNum = Console.ReadLine();
                    if (newCardNum.Length == 16) { return newCardNum; }
                    else { Console.WriteLine("Card not recognized. Please try again!"); }
                }
                catch { Console.WriteLine("Card not recognized. Please try again!"); }
            }
        }

        public static int CheckNewPin()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your four digit pin: ");
                    string newCardPin = Console.ReadLine();
                    if (newCardPin.Length == 4) { return int.Parse(newCardPin); }
                    else { Console.WriteLine("Incorrect pin. please try again!"); }
                }
                catch { Console.WriteLine("Incorrect pin. please try again!"); }
            }
        }

        public static string CheckNewFirstName()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your first name: ");
                    string newFirstName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newFirstName)) { return newFirstName; }
                    else { Console.WriteLine("field canno't be empty!"); }
                }
                catch { Console.WriteLine("field canno't be empty!"); }
            }

        }

        public static string CheckNewLastName()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your last name: ");
                    string newLastName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newLastName)) { return newLastName; }
                    else { Console.WriteLine("field canno't be empty!"); }
                }
                catch { Console.WriteLine("field canno't be empty!"); }
            }
        }
    }
}
