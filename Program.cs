using System;

namespace IncomeComparisonStep67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.Write("What is your hourly rate?: ");
            string hrlyRate1 = Console.ReadLine();
            Console.Write("How many hours do you work per week?: ");
            string hrsWorked1 = Console.ReadLine();
            double wklySalary1 = Convert.ToDouble(hrlyRate1) * Convert.ToDouble(hrsWorked1);

            Console.WriteLine("Person 2");
            Console.Write("What is your hourly rate?: ");
            string hrlyRate2 = Console.ReadLine();
            Console.Write("How many hours do you work per week?: ");
            string hrsWorked2 = Console.ReadLine();
            double wklySalary2 = Convert.ToDouble(hrlyRate2) * Convert.ToDouble(hrsWorked2);

            bool wklySalaryCompare = wklySalary1 > wklySalary2;

            Console.WriteLine("Weekly salary of Person 1: " + wklySalary1);
            Console.WriteLine("Weekly salary of Person 2: " + wklySalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(wklySalaryCompare);
        }
    }
}
