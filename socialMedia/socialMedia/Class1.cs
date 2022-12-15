using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socialMedia
{
    class Profile
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
        private List<Profile> Friends { get; set; }

        public Profile(string name, string id, string address)
        {
            Name = name;
            Id = id;
            Address = address;
            Friends = new List<Profile>();
        }

        public void PrintProfileInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Friends: ");
            ShowFriends();
        }

        public void ShowFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine($"{friend.Name} {friend.Id}");
            }
        }

        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
        }

        public void RemoveFriend(Profile friendToRemove)
        {
            Friends.Remove(friendToRemove);
        }
    }
}
