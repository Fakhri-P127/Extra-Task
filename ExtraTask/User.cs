using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtraTask
{
    class User
    {
        public static List<User> allUsers = new List<User>();
        public static List<User> Friends = new List<User>();
        public string Name { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public User(string name, string fullname, string password)
        {
            Name = name;
            Fullname = fullname;
            Password = password;
        }
        public User()
        {

        }
        public  void AddFriend(string name)
        {
            foreach (var user in allUsers.ToList())
            {
                if (user.Name.ToLower().Trim() == name.ToLower().Trim())
                {
                    Friends.Add(user);
                    Console.WriteLine($"{user.Name} has been added to friendlist");
                    return;
                }
            }
            Console.WriteLine("No user exists with this name");           
        }
        public void AllFriends()
        {                                  
            Friends.ForEach(x => Console.WriteLine(x));            
        }
        public void ShowAllUsers()
        {
            allUsers.ForEach(x => Console.WriteLine(x));
        }
        public void RemoveFriend(string name)
        {
            foreach (var friend in Friends.ToList())
            {
                if(friend.Name.ToLower().Trim() == name.ToLower().Trim())
                {                    
                    Friends.Remove(friend);
                    Console.WriteLine("Successfuly Removed");
                    return; 
                }
            }
            Console.WriteLine("No user exists with this name");                      
        }
        public void Register(string name,string fullname, string password)
        {
            if (!CheckerClass.PasswordChecker(password))
            {
                return;
            }
            if (!CheckerClass.CheckFullname(fullname))
            {
                return;
            }
            if (!CheckerClass.CheckName(name))
            {
                return;
            }            
            User user = new User(name,fullname, password);
            allUsers.Add(user);
            Console.WriteLine($"User registered:\n{user}");
        }               
        public void Login(string name, string password)
        {
            if (allUsers.Count == 0)
            {
                Console.WriteLine("No registered people");
                return;
            }
            if (!CheckerClass.CheckName(name))
            {
                Console.WriteLine("Username incorrect");
                return;
            }
            if (!CheckerClass.PasswordChecker(password))
            {
                Console.WriteLine("The Password doesn't fit the required format");
                return;
            }

            foreach (var item in allUsers)
            {
                if (name == item.Name && password == item.Password)
                {
                    Console.WriteLine($"Welcome {name}");
                    return;
                }
            }          
            Console.WriteLine("This User does not exist!");
            
            
        }
        public override string ToString()
        {
            return $"Username: {Name}, Fullname: {Fullname}, Password {Password}";
        }
    }
}
