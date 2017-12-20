using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// examples here   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/walkthrough-writing-queries-linq

namespace Lambda
{
    class Program
    {
        delegate int del(int i);
        delegate void TestDelegate(string s);

        static void Main(string[] args)
        {
            //LambdaExample3 l3 = new LambdaExample3();

            IEnumerator___IEnumerable ien = new IEnumerator___IEnumerable();

            // use linq with a DataSet from a DataTable
            LinqToDataSet();


            //Application.Run(new AsyncLambdas());

            ////Expression Lambda
            //del myDel = x => x * x;
            //Console.WriteLine("myDel:  " + myDel(3));

            ////Statement Lambdas
            //TestDelegate del = n => {
            //    string s = n + " World";
            //    Console.WriteLine(s);
            //};


            ////Lambdas with the Standard Query Operators
            Func<int, bool> myFunc = x => x == 5;
            bool result = myFunc(4); // returns false of course  

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            int total = numbers.Count();
            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
            var nmb1 = numbers.Where(n => n < 6);
            var AllfirstNumbersLessThan6 = numbers.Take(6);


            Console.ReadKey();
        }

        static void LinqToDataSet()
        {
            //AdventureWorks2014DataSet ds = new AdventureWorks2014DataSet();
            //DataTable dt = ds.vEmployee;

            //DataClasses1DataContext d = new DataClasses1DataContext();            
            //DataTable dt = d.Persons;

            //var adv = from dtAdv in dt.AsEnumerable()
            //          select dtAdv;
            //foreach(var i in adv)
            //{
            //    Console.WriteLine(i.Field<String>("FirstName"));
            //}


            // create a connection to a database
            try
            {
                DataContext db1 = new DataContext(@"c:\db1.mdf");
            }
            catch (Exception ex) { }
            // Get a typed table to run queries.
            //Table<> Customers = db1.GetTable<>();

            //this works
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                IQueryable<String> name = context.Persons.Where(p => p.FirstName.StartsWith("A")).OrderBy(p => p.FirstName).Select(p => p.FirstName);

                foreach (string s in name)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void exp1()
        {
            //Standard Query Operator Extension Methods
            //The following example shows a simple query expression and the semantically equivalent query written as a method-based query.
            /*In the previous example, notice that the conditional expression (num % 2 == 0) is passed as an in-line argument to the Where method: Where(num => num % 2 == 0). This inline expression is called a lambda expression. It is a convenient way to write code that would otherwise have to be written in more cumbersome form as an anonymous method or a generic delegate or an expression tree. In C# => is the lambda operator, which is read as "goes to". The num on the left of the operator is the input variable which corresponds to num in the query expression. The compiler can infer the type of num because it knows that numbers is a generic IEnumerable<T> type. The body of the lambda is just the same as the expression in query syntax or in any other C# expression or statement; it can include method calls and other complex logic. The "return value" is just the expression result. */

            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            //Method syntax:
            IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);

            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);
            foreach (int i in numQuery2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
/* Expression Lambdas
A lambda expression is an anonymous function that you can use to create delegates or expression tree types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.
To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator =>, and you put the expression or statement block on the other side. For example, the lambda expression x => x * x specifies a parameter that’s named x and returns the value of x squared. 
A lambda expression with an expression on the right side of the => operator is called an expression lambda. Expression lambdas are used extensively in the construction of Expression Trees. An expression lambda returns the result of the expression and takes the following basic form:
            (input-parameters) => expression
The parentheses are optional only if the lambda has one input parameter; otherwise they are required. Two or more input parameters are separated by commas enclosed in parentheses:
            (x, y) => x == y  

    Statement Lambdas
A statement lambda resembles an expression lambda except that the statement(s) is enclosed in braces:
        (input-parameters) => { statement; }
The body of a statement lambda can consist of any number of statements; however, in practice there are typically no more than two or three.
            delegate void TestDelegate(string s);
            TestDelegate del = n => { string s = n + " World"; 
                                      Console.WriteLine(s); };
 
    Async Lambdas
You can easily create lambda expressions and statements that incorporate asynchronous processing by using the async and await keywords. For example, the following Windows Forms example contains an event handler that calls and awaits an async method, ExampleMethodAsync.
     
    Lambdas with the Standard Query Operators
Many Standard query operators have an input parameter whose type is one of the Func<T,TResult> family of generic delegates. These delegates use type parameters to define the number and types of input parameters, and the return type of the delegate. Func delegates are very useful for encapsulating user-defined expressions that are applied to each element in a set of source data. For example, consider the following delegate type:
            public delegate TResult Func<TArg0, TResult>(TArg0 arg0) 
The delegate can be instantiated as Func<int,bool> myFunc where int is an input parameter and bool is the return value. The return value is always specified in the last type parameter. Func<int, string, bool> defines a delegate with two input parameters, int and string, and a return type of bool. The following Func delegate, when it is invoked, will return true or false to indicate whether the input parameter is equal to 5:
            Func<int, bool> myFunc = x => x == 5;  
            bool result = myFunc(4); // returns false of course  
     */
