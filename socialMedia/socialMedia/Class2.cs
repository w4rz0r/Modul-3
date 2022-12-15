using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socialMedia
{
    class SocialNetwork
    {
        private List<Profile> ListOfUsers { get; set; }
        private Profile loggedInProfile;

        public SocialNetwork()
        {
            loggedInProfile = new Profile("Bjarne", "0", "santiago");

            ListOfUsers = new List<Profile>();
            ListOfUsers.Add(new Profile("Marie", "1", "hakkebakkeskogen"));
            ListOfUsers.Add(new Profile("Terje", "2", "italia"));
            ListOfUsers.Add(new Profile("Bjørnar", "3", "melkeveien"));
            ListOfUsers.Add(new Profile("Linn", "4", "antarktika"));

            while (true)
            {
                PrintMenu();
                var userInput = Console.ReadLine();
                HandleMenuOption(userInput);
            }
        }

        private void ShowUsers()
        {
            foreach (var user in ListOfUsers)
            {
                Console.WriteLine($"{user.Name} {user.Id} {user.Address}");
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Welcome to MySpace");
            Console.WriteLine("Option 1: Add Friend");
            Console.WriteLine("Option 2: Remove Friend");
            Console.WriteLine("Option 3: Print Friends");
            Console.WriteLine("Option 4: Print FriendInfo");
        }

        private void HandleMenuOption(string menuOption)
        {
            if (menuOption == "1")
            {
                Console.WriteLine("MenuOption 1: Add Friend: ");
                ShowUsers();
                Console.WriteLine("Choose The Id Of The User You Want To Add");
                var chosenUserId = Console.ReadLine();
                var userProfile = GetUserProfile(chosenUserId);
                loggedInProfile.AddFriend(userProfile);
            }
            if (menuOption == "2")
            {
                loggedInProfile.ShowFriends();
                Console.WriteLine("Choose Wich Friend To Remove");
                var friendId = Console.ReadLine();
                var profileToRemove = GetUserProfile(friendId);
                loggedInProfile.RemoveFriend(profileToRemove);
            }
            if (menuOption == "3")
            {
                loggedInProfile.ShowFriends();
            }
            if (menuOption == "4")
            {
                loggedInProfile.ShowFriends();
                var friendId = Console.ReadLine();
                var profile = GetUserProfile(friendId);
                profile.PrintProfileInfo();
            }
        }

        private Profile GetUserProfile(string id)
        {
            return ListOfUsers.FirstOrDefault(user => user.Id == id);
        }
    }
}
