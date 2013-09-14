using System;

// ReSharper disable CheckNamespace
namespace Animaonline
// ReSharper restore CheckNamespace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Animaonline Android Console{0}" +
                              "Type 'exit' to abort...", Environment.NewLine);

            bool keepAlive = true;

            while (keepAlive)
            {
                Console.Write("Enter a word:");

                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.ToLower().Equals("exit"))
                    keepAlive = false;
                else
                    Console.WriteLine("You entered '{0}'", input);
            }

            Console.WriteLine("{0}Executed completed...", Environment.NewLine);
        }
    }
}