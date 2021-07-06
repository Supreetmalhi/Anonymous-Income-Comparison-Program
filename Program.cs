using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Double HrRateP1, HrRateP2, HrWorkedP1, HrWorkedP2, AnnualSalP1, AnnualSalP2;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            HrRateP1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            HrWorkedP1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            HrRateP2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            HrWorkedP2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            AnnualSalP1 = HrRateP1 * (HrWorkedP1 * 52);
            Console.WriteLine(AnnualSalP1);

            Console.WriteLine("Annual salary of Person 2:");
            AnnualSalP2 = HrRateP2 * (HrWorkedP2 * 52);
            Console.WriteLine(AnnualSalP2);

            Console.WriteLine("Person 1 makes more money than Person 2");
            if (AnnualSalP1 > AnnualSalP2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
