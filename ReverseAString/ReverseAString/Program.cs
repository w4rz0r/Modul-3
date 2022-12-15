namespace ReverseAString
{
    internal class Program
    {
        static string Backwards(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new(charArray);
            return reversed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something and i will reverse it!");
            var userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                var charArray = Backwards(userInput);
                Console.WriteLine($"{userInput} in reverse is: {charArray}");
            }
        }

        //var reverse = string.Empty;
        //Console.WriteLine("Please write something and i will reverse it!");
        //    var userInput = Console.ReadLine();
        //    if (!string.IsNullOrEmpty(userInput))
        //    {
        //        for (int i = userInput.Length - 1; i >= 0; i--)
        //        {
        //            reverse += userInput[i];
        //        }
        //        Console.WriteLine($"the reverse of {userInput} is {reverse}");
        //    }
    }
}