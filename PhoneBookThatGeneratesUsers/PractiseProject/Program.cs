using System.Text;
namespace PractiseProject;

class Program
{
    public static List<People> Users = new();

    static readonly Random random = new();

    public static int option = 0;

    public static int numbersRequired = 8;
    public static int Number { get; set; }
    public static int InputNumber { get; set; }




    static void PrintOptions()
    {
        Console.WriteLine("Please choose an option: ");
        Console.WriteLine("1. Create user");
        Console.WriteLine("2. Print some users");
        Console.WriteLine("3. Print all users");
        Console.WriteLine("4. make new dummy users");
        Console.WriteLine("5. Exit");
    }

    static void ExecuteOptions()
    {
        do
        {
            PrintOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Options failed!"); break; }
            if (option == 1) { UserInput(); }
            else if (option == 2) { PrintUsers(); }
            else if (option == 3) { PrintAllUsers(); }
            else if (option == 4) { MakeDummyData(); }
            else if (option == 5) { Environment.Exit(0); }
        }
        while (option != 6);
    }



    static void UserInput()
    {
        Console.WriteLine("Please enter a name: ");
        var Name = Console.ReadLine();
        if (!string.IsNullOrEmpty(Name))
        {
            Console.WriteLine("Please enter a Number: ");
            try
            {
                Number = int.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Sorry but the number is invalid!\n"); }
            if (Number.ToString().Length == 8)
            {
                Users.Add(new People(Name, Number));
            }
        }

    }

    static void PrintUsers()
    {
        var printingNumber = 0;
        Console.WriteLine("Please enter how many users you'd like to print!");
        NumberInputParse();
        foreach (var user in Users)
        {
            if (printingNumber < InputNumber)
            {
                Console.WriteLine($"Name: {user.Name}\nNumber: {user.Number}");
                printingNumber++;
            }
        }
    }

    static void PrintAllUsers()
    {
        foreach (var user in Users)
        {
            Console.WriteLine($"Name: {user.Name}\nNumber: {user.Number}\n");
        }
    }

    static void MakeDummyData()
    {
        var name = new ListOfNames();
        Console.WriteLine("How many new users would you like to create?");
        NumberInputParse();
        if (InputNumber <= 20)
        {
            for (int i = 0; i < InputNumber; i++)
            {
                var dummyName = name.names[random.Next(name.names.Length)];
                var dummyNumber = int.Parse(GenerateRandomPhoneNumber());
                Users.Add(new People(dummyName, dummyNumber));
            }
            Console.WriteLine($"{InputNumber} new users have now been added!");
        }
        else { Console.WriteLine("Maximum number of 20 exceeded!"); }

    }

    static int NumberInputParse()
    {
        try
        {
            InputNumber = int.Parse(Console.ReadLine());
        }
        catch { Console.WriteLine("Sorry but the number is invalid!"); }
        return InputNumber;
    }

    public static string GenerateRandomPhoneNumber()
    {
        return string.Format("07{0}", GeneratRandomNumber(7));
    }
    public static string GeneratRandomNumber(int length)
    {
        if (length > 0)
        {
            var sb = new StringBuilder();
            var rnd = SeedRandom();
            for (int i = 0; i < length; i++)
            {
                sb.Append(rnd.Next(0, 9).ToString());
            }
            return sb.ToString();
        }
        return string.Empty;
    }
    private static Random SeedRandom()
    {
        return new Random(Guid.NewGuid().GetHashCode());
    }



    static void Main(string[] args)
    {
        Users.Add(new People("james", 48832983));
        Users.Add(new People("wanny", 26942874));
        Users.Add(new People("morten", 53103784));
        Users.Add(new People("felix", 25839210));
        Users.Add(new People("kassandra", 38389385));

        ExecuteOptions();
    }
}