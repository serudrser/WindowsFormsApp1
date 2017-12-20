using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            int[] A = { 1, 3, 6, 4, 1, 2 };
            //c1 c = new c1();
            //c1.solution(A);

            //Class1 c1 = new Class1("00-44  48 5555 8361");
            //Class1 c1 = new Class1("0 - 22 1985--324");
            //Class1 c1 = new Class1("555372654");
            //Class1 c1 = new Class1("0 - 22 1985--324");

            //int[] a = new int[] { 3, 5, 6, 3, 3, 5 };
            //Class2 c2 = new Class2(a);

            //Linq l = new Linq();
            //LinqJoin lj = new LinqJoin();
            Thread1 t = new Thread1();
        }
    }
}
