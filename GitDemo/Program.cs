using System;

namespace GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employees:");
            string NumUserString = Console.ReadLine();
            int NumUser = Int16.Parse(NumUserString);
            Console.Clear();
            string[] name = new string[NumUser]; 
            int[] salary = new int[NumUser];
            for (int i = 0; i < NumUser; i++)
            {
                Console.WriteLine("Enter your name:");
                string v = Console.ReadLine();
                name[i] = v;
                Console.WriteLine("Enter your Salary:");
                salary[i] = Int16.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < NumUser; i++)
            {
                Console.WriteLine(name[i]+ salary[i]);


            }



        }
    }
}
