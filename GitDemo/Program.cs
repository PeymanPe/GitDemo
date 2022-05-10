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
            string[] name = new string[NumUser]; 
            int[] salary = new int[NumUser];
            for (int i = 0; i < NumUser; i++)
            {
                Console.WriteLine("Enter your name:");
                string v = Console.ReadLine();
                string name[i] = v;
                Console.WriteLine("Enter your Salary:");
                //int salary[i] = Int16.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < NumUser; i++)
            {
                //Console.WriteLine(name[i]);
                Console.WriteLine("");
                
                //Console.WriteLine(salary[i]);
                
            }



        }
    }
}
