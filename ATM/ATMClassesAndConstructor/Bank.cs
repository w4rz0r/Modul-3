namespace ATMClassesAndConstructor
{
    public class Bank 
    {
        public List<CardHolder> CardHolders { get; set; }
        private readonly Random random = new();


        public Bank()
        {
            CardHolders = new List<CardHolder>
            {
                new CardHolder("9702339611732561", 1234, "Wanny", "McSwaggy", 7392.31),
                new CardHolder("9755471004898331", 4321, "Sigrid", "Flatby", 3210.13),
                new CardHolder("7380810128687931", 9999, "Frida", "Tresko", 1050.59),
                new CardHolder("7700807624436495", 2468, "Bjørnar", "Sweglord", 8510.84),
                new CardHolder("7834858829345307", 4826, "Fritjof", "Nansen", 540.27),
                new CardHolder("1234", 1234, "turbo", "smacker", 9940.27),
            };
        }

        
        public void AddNewCustomer()
        {
            var cardNum = CreateNewUser.CheckNewCardNum();
            var pin = CreateNewUser.CheckNewPin();
            var firstName = CreateNewUser.CheckNewFirstName();
            var lastName = CreateNewUser.CheckNewLastName();
            var balance = random.Next(420, 8000);

            CardHolders.Add(new CardHolder(cardNum, pin, firstName, lastName, balance));
        }
    }
}
