using System;

namespace GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employees:");
            int NumUser = Int16.Parse(Console.ReadLine());
            Console.Clear();
            string[] name;
            string[] salary;
            for (int i = 0; i < NumUser; i++)
            {
                Console.WriteLine("Enter your name:");
                string name[i] = Console.ReadLine();
                Console.WriteLine("Enter your Salary:");
                int salary[i] = Int16.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < NumUser; i++)
            {
                Console.WriteLine(name[i]);
                
                Console.WriteLine(salary[i]);
                
            }



        }
    }
}
