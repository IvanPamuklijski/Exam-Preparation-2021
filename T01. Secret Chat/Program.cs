using System;
using System.Text;

namespace T01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder message = new StringBuilder(input);
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                var operation = command.Split("|");
                if (operation[0] == "ChangeAll")
                {
                    message.Replace(operation[1], operation[2]);

                }
                else if (operation[0] =="Insert")
                {
                    int index = int.Parse(operation[1]);
                    message.Insert(index, operation[2]);

                }
                else if (operation[0] == "Move")
                {
                    int index = int.Parse(operation[1]);
                    string substring = message.ToString().Substring(0, index);
                    message.Remove(0, index);
                    message.Append(substring);
                   
                   
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
