using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Func_T_TResult___Delegate
    {
        // Delegate Func<T,TResult>  - Encapsulates a method that has one parameter and returns a value of the type specified by the TResult parameter.   
        //  public delegate TResult Func<in T, out TResult>(T arg);

        // The following example demonstrates how to declare and use a Func<T,TResult> delegate. This example declares a Func<T,TResult> variable and assigns it a lambda expression that converts the characters in a string to uppercase. The delegate that encapsulates this method is subsequently passed to the Enumerable.Select method to change the strings in an array of strings to uppercase.

        // https://docs.microsoft.com/en-us/dotnet/api/system.func-2?view=netframework-4.7.1
        public Func_T_TResult___Delegate()
        {
            // Declare a Func variable and assign a lambda expression to the variable. The method takes a string and converts it to uppercase.
            Func<string, string> selector = str => str.ToUpper();

            // Create an array of strings.
            string[] words = { "orange", "apple", "Article", "elephant" };
            // Query the array and select strings according to the selector method.
            IEnumerable<String> aWords = words.Select(selector);

            IEnumerable<String> aWords2 = words.Select(str2 => str2.ToUpper());

            // Output the results to the console.
            foreach (String word in aWords)
                Console.WriteLine(word);
        }
    }
}
