namespace CountChars;

public class Program
{
    static void Main(string[] args)
    {
        ReadTextAndCountCharacters();
    }

    private static void ReadTextAndCountCharacters()
    {
        string text = "something";

        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();

            var counts = AddCharactersToCount(text);

            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    double percentage = GetPercentage(counts[i], text.Length);
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i] + " " + percentage + "%");
                }
            }
        }
    }

    private static int[] AddCharactersToCount(string text)
    {
        var counts = new int[250];

        foreach (var character in text ?? string.Empty)
        {
            counts[(int)character]++;
        }

        return counts;
    }

    private static double GetPercentage(int characterCount, int totalCharacters)
    {
        return (int)Math.Round((double)(100 * characterCount) / totalCharacters);
    }


    //private static void ReadTextAndUpdateAndShowCharCounts(int range)
    //{
    //    var counts = new int[range];

    //    string text = "something";
    //    while (!string.IsNullOrWhiteSpace(text))
    //    {
    //        text = Console.ReadLine().ToLower();
    //        var counts = CountChars(text, range, total);
    //        ShowCounts(range, counts);
    //    }
    //}

    //private static void ShowCounts(int range, int[] counts, int letterPercentage)
    //{
    //    for (var i = 0; i < range; i++)
    //    {
    //        if (counts[i] == 0) continue;
    //        var character = (char)i;
    //        Console.WriteLine("\"" + character + "\" - " + counts[i] + "percentage: " + letterPercentage + "%");

    //    }
    //    CalculatePercentage(percentPerChar, total);
    //}

    //private static int[] CountChars(string text, int range, int total)
    //{
    //    var counts = new int[range];
    //    foreach (var character in text)
    //    {
    //        counts[(int)character]++;
    //        total++;
    //    }
    //    return counts;
    //}

    //private static void CalculatePercentage(int percentPerChar, int total)
    //{
    //    int letterPercentage = (int)Math.Round((double)(100 * percentPerChar) / total);
    //}
}