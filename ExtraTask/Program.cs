using System;
using System.Collections.Generic;

namespace ExtraTask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            do
            {
                // Bu funksiyalari etmek ucun gerek user Login olsun amma onu etmeye axot olmadi :/
                Console.WriteLine("Welcome");
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Add Friend");
                Console.WriteLine("4.Remove Friend");
                Console.WriteLine("5.Show FriendList");
                Console.WriteLine("6.Show All Users");
                Console.WriteLine("0.Exit");                
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        UsersMenu.RegisterMenu();
                        break;
                    case 2:
                        UsersMenu.LoginMenu();
                        break;
                    case 3:
                        UsersMenu.AddFriendMenu();
                        break;
                    case 4:
                        UsersMenu.RemoveFriendMenu();
                        break;
                    case 5:
                        UsersMenu.ShowAllFriendsMenu();
                        break;
                    case 6:
                        UsersMenu.ShowAllUsersMenu();
                        break;
                    case 0:
                        Console.WriteLine("You exited the application");
                        return;
                    default:
                        Console.WriteLine("Defaultt");
                        break;
                }            
        } while (true);

            
        }
    }
}
#region
//User.Register();
//User.Register();
//User.Login("salam", "fakhri");
//User user = new User("Fasx200", "Fakhri Afandiyev", "ffvii444");
//User.AddFriend(user);
//User.AllFriends();
//Console.WriteLine("The you want to delete");
//string name = Console.ReadLine();
//User.RemoveFriend(name);
//if (User.Friends.Count == 0)
//{
//    Console.WriteLine("NO MAIDENS");
//}
//foreach (var item in User.Friends)
//{
//    Console.WriteLine(item.Name); ;
//}
#endregion