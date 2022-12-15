namespace ATMClassesAndConstructor
{
    public class OptionMethods
    {
        public void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.Balance += deposit;
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.Balance);
        }

        public void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw? ");
            double withdraw = Double.Parse(Console.ReadLine());
            if (currentUser.Balance < withdraw)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                currentUser.Balance -= withdraw;
                Console.WriteLine("Youre all set, Your new balance is: " + currentUser.Balance + " Thank you!");
            }
        }

        public void Balance(CardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.Balance);
        }
    }
}