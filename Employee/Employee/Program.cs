using System;

namespace Employee
{
    public class Program
    {
        //THis is UC1
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("\t Employee is Present...");
            }
            else
            {
                Console.WriteLine("\t Employee is Absent...");
            }

        }

    }
}
