using ConsoleApp27.Entities;
using System.Collections.Generic;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<Courses> set = new HashSet<Courses>();
            
            for (int i = 0; i < 3; i++)
            {
                int result = default;
                string input;
                int counter = 65;

                Console.Write("\nHow many students for course " + Convert.ToChar(65 + i) + " : ");
                int students = int.Parse(Console.ReadLine());

                for (int j = 0; j < students; j++)
                {
                    Console.Write("Enter the id of the student: ");
                    input = Console.ReadLine();
                    while (!int.TryParse(input, out result))
                    {
                        Console.Write("Invalid input, try again: ");
                        input = Console.ReadLine();
                    }

                    set.Add(new Courses(result));

                }
            }

            Console.WriteLine("\nTotal students: " + set.Count);
        }
    }
}
