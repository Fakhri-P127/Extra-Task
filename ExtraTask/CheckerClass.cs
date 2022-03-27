using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtraTask
{
   public static class CheckerClass
    {
        public static bool CheckFullname(string fullname)
        {
            if (fullname.Length > 30)
            {
                Console.WriteLine($"{fullname} is too long. Enter less than 30 characters.");
                return false;
            }
            foreach (char letter in fullname)
            {
                if (char.IsDigit(letter))
                {                   
                    Console.WriteLine("No digits allowed.");
                    return false;
                }
            }
            string[] splitFullname = fullname.Split(" ");
            if ((splitFullname.Length == 2)) //2 because(name and surname)
            {
                if (splitFullname[0].Length >= 3 && splitFullname[1].Length >= 3)
                {
                    return true;
                }
                Console.WriteLine("Both Name and Surname needs to be at least 3 characters.");
                return false;
            }
            Console.WriteLine("Fullname must include: Name + Space + Surname. Example(Fakhri Afandiyev)");
            return false;
        }
        public static bool CheckName(string name)
        {
            if(name.Length<6 && name.Length > 16)
            {
                Console.WriteLine("LENFTH");
                return false;
            }
            if (name.Any(x => !char.IsLetterOrDigit(x)))
            {
                Console.WriteLine("NO SYMBIOTS");
                return false;
            }
            
            return true;
        }
        public static bool PasswordChecker(string password)
        {
            if (password.Length < 8 || password.Length > 32)
            {
                Console.WriteLine("Password must be between 8 and 32 characters.");
                return false;
            }
            bool result = password.Any(x => char.IsDigit(x));
            bool result1 = password.Any(x => char.IsUpper(x));
            bool result2 = password.All(x => char.IsLetterOrDigit(x));
            if (!result || !result1 || !result2)
            {
                Console.WriteLine("Input valid value");
                return false;
            }
            return true;
        }
    }
}
