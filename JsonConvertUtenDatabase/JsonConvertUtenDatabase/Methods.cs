using Newtonsoft.Json;
namespace JsonConvertUtenDatabase
{
    //package manager console: NuGet\Install-Package Newtonsoft.Json -Version 13.0.1
    internal class Methods
    {
        static string fileName = $"C:\\code\\csvjson.json";
        static string jsonString = File.ReadAllText(fileName);
        static List<Workshop> list = new();
        static List<Workshop> matches = new();
        static List<string> ApprovalTypes = new();

        public Methods()
        {
            list = JsonConvert.DeserializeObject<List<Workshop>>(jsonString);
        }

        public void PrintAreas()
        {
            Console.WriteLine("Choose an area: ");
            Console.WriteLine("1. Oslo");
            Console.WriteLine("2. Akershus");
            Console.WriteLine("3. Østfold");
            Console.WriteLine("4. Hedmark");
            Console.WriteLine("5. Oppland");
            Console.WriteLine("6. Buskerud");
            Console.WriteLine("7. Vestfold");
            Console.WriteLine("8. Telemark");
            Console.WriteLine("9. Rogaland");
            Console.WriteLine("10. Vest-Agder");
            Console.WriteLine("11. Aust-Agder");
            Console.WriteLine("12. Hordaland");
            Console.WriteLine("13. Sogn Og Fjordane");
            Console.WriteLine("14. Møre Og Romsdal");
            Console.WriteLine("15. Sør-Trøndelag");
            Console.WriteLine("16. Nord-Trøndelag");
            Console.WriteLine("17. Nordland");
            Console.WriteLine("18. Troms");
            Console.WriteLine("19. Finnmark");
        }

        public void ExecuteAreas()
        {
            var option = 0;
            PrintAreas();
            do
            {
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { break; }
                if (option == 1) { FilterMethods(PCBA.Oslo); }
                else if (option == 2) { }
                else if (option == 3) { }
                else if (option == 4) { }
                else if (option == 5) { }
                else if (option == 6) { }
                else if (option == 7) { }
                else if (option == 8) { }
                else if (option == 9) { }
                else if (option == 10) { }
                else if (option == 11) { }
                else if (option == 12) { }
                else if (option == 13) { }
                else if (option == 14) { }
                else if (option == 15) { }
                else if (option == 16) { }
                else if (option == 17) { }
                else if (option == 18) { }
                else if (option == 19) { }
                else { break; }

            }
            while (option != 20);
        }

        public void FilterMethods(string[] AreaPostCodes)
        {
            FilterByArea(AreaPostCodes);
            if (matches.Count != 0)
            {
                PrintApprovalTypes();
                FilterByApprovalTypes();
            }
            else
            {
                Console.WriteLine($"Sorry but we found {matches.Count} matches, Please try again!");
            }
        }

        public void FilterByArea(string[] AreaPostCodes)
        {
            foreach (var workshop in list)
            {
                foreach (var code in AreaPostCodes)
                {
                    if (workshop.Postnummer.StartsWith(code))
                    {
                        matches.Add(workshop);
                        Console.WriteLine($"{workshop.Poststed.ToLower()} {workshop.Bedriftsnavn} {workshop.Postnummer}\n");
                    }
                }
            }
        }

        private void PrintApprovalTypes()
        {
            foreach (var Match in matches)
            {
                foreach (var item in Match.Godkjenningstyper.ToLower().Split(", "))
                {
                    if (!ApprovalTypes.Contains(item))
                    {
                        ApprovalTypes.Add(item);
                    }
                }
            }
            Console.WriteLine($"{ApprovalTypes.Count} godkjenningstyper tilgjengelige: {String.Join(", ", ApprovalTypes.ToArray())}");
        }



        public void FilterByApprovalTypes()
        {
            Console.WriteLine("Please enter approval type: ");
            var approvalTypesInput = Console.ReadLine().ToLower();
            approvalTypesInput.Split(" ");
            foreach (var workshop in matches)
            {
                foreach (var type in approvalTypesInput)
                {
                    if (workshop.Godkjenningstyper.ToLower().Contains(approvalTypesInput))
                    {
                        Console.WriteLine($"{workshop.Poststed.ToLower()} {workshop.Bedriftsnavn} {workshop.Postnummer}\n");
                    }
                }
            }
        }
    }
}
