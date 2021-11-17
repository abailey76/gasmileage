using System;

namespace gasmileage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int milesDriven, gasConsumed, gasMileage;

            Console.WriteLine("How many miles did you drive?");

            milesDriven = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many gallons of gas did you burn?");

            gasConsumed = Convert.ToInt32(Console.ReadLine());

            gasMileage = milesDriven / gasConsumed;

            Console.WriteLine("Your gas mileage is: {0}", gasMileage);

            Console.ReadKey();

            
        }
    }
}
