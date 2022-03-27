using System;
using System.Collections.Generic;
using System.Text;

namespace ExtraTask
{
   
    class UsersMenu
    {
        public static User user = new User();
        public static void LoginMenu()
        {
            Console.WriteLine("Write Username");
            string username = Console.ReadLine();
            Console.WriteLine("Write Password");
            string password = Console.ReadLine();
            user.Login(username, password);
        }
        public static void RegisterMenu()
        {
            Console.WriteLine("Write Username");
            string username = Console.ReadLine();
            Console.WriteLine("Write Fullname");
            string fullname = Console.ReadLine();
            Console.WriteLine("Write Password");
            string password = Console.ReadLine();
            user.Register(username,fullname, password);
        }
        public static void ShowAllFriendsMenu()
        {
            user.AllFriends();
        }
        public static void AddFriendMenu()
        {
            Console.WriteLine("Enter the username you want to add to be friends with");
            string name = Console.ReadLine();
            user.AddFriend(name);
        }
        public static void RemoveFriendMenu()
        {
            string name = Console.ReadLine();
            user.RemoveFriend(name);
        }
        public static void ShowAllUsersMenu()
        {
            user.ShowAllUsers();
        }
    }
}
