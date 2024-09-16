using System;
using Csharp3.Classes;
using Csharp3.Interfaces;

namespace Csharp3
{
    internal class Program
    {
        //static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            //object instance ctor
            BankAccount bankAccount = new BankAccount(1000);
            bankAccount.AddToBalance(100);

            SimpleMath simpleMath = new SimpleMath();

            //using interfaces to call class
            Console.WriteLine(Information(bankAccount));



            Console.ReadLine();
        }

        private static string Information(IInformation information)
        {
            return information.GetInformation();
        }
    }

    class SimpleMath : IInformation
    {
        //overloading method
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        //overloading method
        public static double Add(double[] numbers)
        {
            double result = 0;
            foreach (double d in numbers)
            {
                result += d;
            }
            return result;
        }

        public string GetInformation()
        {
            return "Class that solves simple math.";
        }
    }
}
