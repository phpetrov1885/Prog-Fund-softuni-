using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogsRegister =
                new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ').ToArray();
                var ipArgs = tokens[0].Split('=').ToArray();
                var messageArgs = tokens[1].Split('=').ToArray();
                var userArgs = tokens[2].Split('=').ToArray();
                var ip = ipArgs[1];
                var message = messageArgs[1];
                var userName = userArgs[1];

                if (message != null)
                {
                    int count = 1;
                    if (!userLogsRegister.ContainsKey(userName))
                    {
                        userLogsRegister.Add(userName, new Dictionary<string, int>());
                    }
                    if (!userLogsRegister[userName].ContainsKey(ip))
                    {
                        userLogsRegister[userName].Add(ip, count);
                    }
                    else
                    {
                        userLogsRegister[userName][ip] += count;
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var users in userLogsRegister)
            {
                var user = users.Key;
                var messages = users.Value;
                Console.WriteLine($"{user}: ");
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.Key} => {message.Value},");
                }

            }
        }
    }
}
