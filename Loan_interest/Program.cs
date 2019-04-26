using System;

namespace Loan_interest
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueCheck = "y";

            while (continueCheck == "y")
            {
                int count = 1;
                string tap = "\t\t\t\t";
                var data = new Cal_Fomula();
                var year = new Cal_Fomula[data.years];


                Console.WriteLine("\n\n\t\t\t\tplease enter your balance");
                Console.Write("\n\n\t\t\t\tBalance = ");
                data.balance = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n\t\t\t\tplease enter Years");
                Console.Write("\n\n\t\t\t\tYears = ");
                data.years = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n\t\t\t\tplease enter rate ");
                Console.Write("\n\n\t\t\t\tRate = ");
                data.rate = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n\t\t\t\t--------------------------------------------------");
                Console.WriteLine("\t\t\t\tLone Interest Result");
                Console.WriteLine("\t\t\t\tBalance         : " + data.balance);
                Console.WriteLine("\t\t\t\tNumber of years : " + data.years);
                Console.WriteLine("\t\t\t\tInterest rate   : " + data.rate + "%\n");

                for (int i = 0; i < data.years; i++)
                {
                    int Result = (data.balance * data.rate / 100) + data.balance;
                    Console.Write($"{tap}{count} Year = ");
                    Console.WriteLine(Result);
                    count++;
                    data.balance = Result;
                    
                }
                Console.WriteLine("\n\n\t\t\t\t--------------------------------------------------");
                Console.WriteLine("\n\n\t\t\t\tDo you want to continus ? (y/n)");
                continueCheck = Console.ReadLine();

                if(continueCheck == "y")
                {
                    Console.Clear();
                }

            }

            Console.WriteLine("Thank for Used");
           
            //CalculateSum calculator = new CalculateSum();
            //calculator.Run_Calulate(year);

        }
    }
}
