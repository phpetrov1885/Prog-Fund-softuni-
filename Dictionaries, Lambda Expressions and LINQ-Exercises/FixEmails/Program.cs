using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailDic = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (!emailDic.ContainsKey(name))
                {
                    emailDic.Add(name, email);
                }
                name = Console.ReadLine();
            }

            foreach (var user in emailDic)
            {
                if (!(user.Value.EndsWith("us") || user.Value.EndsWith("uk")))
                {
                    Console.WriteLine($"{user.Key} -> {user.Value} ");
                }
            }
        }
    }
}
