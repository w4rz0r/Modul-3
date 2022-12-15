string noun;
string adjective;
string noun2;
string verb;

while (true)
{
    try
    {
        Console.WriteLine("Please provide a noun: ");
        noun = Console.ReadLine();
        if (noun.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("There was an error" + e); }
}

while (true)
{
    try
    {
        Console.WriteLine("Please provide an adjective: ");
        adjective = Console.ReadLine();
        if (adjective.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("There was an error" + e); }
}

while (true)
{
    try
    {
        Console.WriteLine("Please provide a second noun: ");
        noun2 = Console.ReadLine();
        if (noun2.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("There was an error" + e); }
}

while (true)
{
    try
    {
        Console.WriteLine("Please provide a verb: ");
        verb = Console.ReadLine();
        if (verb.Length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("There was an error" + e); }
}


string story = "Just then a " + noun + " rang, and the green girl said to Dorothy, \"That is the signal. you must go into the Throne Room alone.\" "
    + "She opened a " + adjective + " door and Dorothy walked boldly through and found herself in a wonderful place. It was a big, round room with a high arched " + noun2 + ", "
    + "and the walls and ceiling and the floor were covered with large emeralds set closely together. In the center of the roof was a great light, as bright as the sun, "
    + "which made the emeralds " + verb + " in a wonderful manner.";

Console.WriteLine("Here is your final story: ");
Console.WriteLine(story);