using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    class Action_T_delegate
    {
        // https://docs.microsoft.com/en-us/dotnet/api/system.action-1?view=netframework-4.7.1
        // Action<T> Delegate - Encapsulates a method that has a single parameter and does not return a value.
        // Action<T1,T2> Delegate - Encapsulates a method that has two parameters and does not return a value.

        public Action_T_delegate()
        {
            exp1(); // with lambda
            exp2(); // using ForEach method
        }

        public void exp1()
        {
            Action<string> messageTarget;

            if (Environment.GetCommandLineArgs().Length > 1)
                messageTarget = s => ShowWindowsMessage(s);
            else
                messageTarget = s => Console.WriteLine(s);

            messageTarget("Hello, World!");
        }

        private void ShowWindowsMessage(string message)
        {
            MessageBox.Show(message);
        }


        //The following example demonstrates the use of the Action<T> delegate to print the contents of a List<T> object. In this example, the Print method is used to display the contents of the list to the console. In addition, the C# example also demonstrates the use of anonymous methods to display the contents to the console. Note that the example does not explicitly declare an Action<T> variable. Instead, it passes a reference to a method that takes a single parameter and that does not return a value to the List<T>.ForEach method, whose single parameter is an Action<T> delegate. Similarly, in the C# example, an Action<T> delegate is not explicitly instantiated because the signature of the anonymous method matches the signature of the Action<T> delegate that is expected by the List<T>.ForEach method.

        public void exp2()
        {
            List<String> names = new List<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            // Display the contents of the list using the Print method.
            names.ForEach(Print);

            // The following demonstrates the anonymous method feature of C#
            // to display the contents of the list to the console.
            names.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });
        }
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}