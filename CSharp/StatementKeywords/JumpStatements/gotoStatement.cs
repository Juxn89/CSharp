using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.StatementKeywords.JumpStatements
{
    class gotoStatement
    {
        static void Main(string[] args)
        {
            /*
                The goto statement transfers the program control directly to a labeled statement.
                A common use of goto is to transfer control to a specific switch-case label or the default label in a switch statement.
                The goto statement is also useful to get out of deeply nested loops.
             */
            int x = 200, y = 4;
            int count = 0;
            string[,] array = new string[x, y];

            // Initialize the array.
            for (int i = 0; i < x; i++)

                for (int j = 0; j < y; j++)
                    array[i, j] = (++count).ToString();

            // Read input.
            Console.Write("Enter the number to search for: ");

            // Input a string.
            string myNumber = Console.ReadLine();

            // Search.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (array[i, j].Equals(myNumber))
                    {
                        goto Found;
                    }
                }
            }

            Console.WriteLine($"The number {myNumber} was not found.");
            goto Finish;

        Found:
            Console.WriteLine($"The number {myNumber} is found.");

        Finish:
            Console.WriteLine("End of search.");

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
