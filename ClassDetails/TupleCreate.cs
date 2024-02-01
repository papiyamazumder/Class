using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    internal class TupleCreate
    {
        #region Tuple create new method with named tuples:

        //static void Main()
        //{
        //    var values = new List<double>() { 10, 20, 30, 40, 50 };
        //    var result = Calulate(values);
        //    Console.WriteLine($"There are {result.count} values and their sum is {result.sum}");
        //    Console.ReadKey();
        //    // Or
        //    var (countResult, SumResult) = Calulate(values);        // Provide Explicitly Names While Storing the Result-
        //    Console.WriteLine($"There are {countResult} values and their sum is {SumResult}");
        //}

        //private static (int count, double sum) Calulate(IEnumerable<double> values)
        //{
        //    int count = 0;
        //    double sum = 0.0;
        //    foreach (var value in values)
        //    {
        //        count++;
        //        sum += value;
        //    }
        //    return (count, sum);
        //}

        #endregion

        #region Tuple create old method:

        //static void Main()
        //{
        //    var values = new List<double>() { 10, 20, 30, 40, 50 };
        //    //Store the Result of Calulate Method in a variable of Tuple type 
        //    Tuple<int, double> t = Calulate(values);
        //    //Access the First value using Item1 and second value using Item2 properties
        //    Console.WriteLine($"There are {t.Item1} values and their sum is {t.Item2}");
        //    Console.ReadKey();
        //}
        ////Declaring the return type as Tuple<int, double>
        //private static Tuple<int, double> Calulate(IEnumerable<double> values)
        //{
        //    int count = 0;
        //    double sum = 0.0;
        //    foreach (var value in values)
        //    {
        //        count++;
        //        sum += value;
        //    }
        //    //Creating an object of Tuple class by calling the static Create method
        //    Tuple<int, double> t = Tuple.Create(count, sum);
        //    //Returning the tuple instance
        //    return t;
        //}

        #endregion
    }

}

