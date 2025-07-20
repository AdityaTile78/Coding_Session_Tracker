using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Session_Tracker.Services
{
    public static class UserInput
    {
        public static string GetDateTime(string prompt)
        {
            Console.WriteLine($"{prompt} (format: yyyy-MM-dd HH:mm)");

            string input = Console.ReadLine();

            while (!Validation.IsValidDateTime(input))
            {
                Console.WriteLine("❌ Invalid format. Please use yyyy-MM-dd HH:mm:");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int GetInteger(string prompt)
        {
            Console.WriteLine(prompt);

            string input = Console.ReadLine();
            while (!Validation.IsValidInteger(input))
            {
                Console.WriteLine("❌ Invalid input. Please enter a number:");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
    }
}
