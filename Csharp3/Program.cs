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
            double[] numbers = new double[] { 1, 2, 3, 42, 42154 };
            var result = SimpleMath.Add(numbers);
            Console.WriteLine(result);

            //object instance ctor
            BankAccount bankAccount = new BankAccount();
            bankAccount.AddToBalance(200);
            Console.WriteLine(bankAccount.Balance);

            //callee child inherit ctor
            ChildBankAccount childBankAccount = new ChildBankAccount();
            childBankAccount.AddToBalance(100);
            Console.WriteLine(childBankAccount.Balance);



            Console.ReadLine();
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
