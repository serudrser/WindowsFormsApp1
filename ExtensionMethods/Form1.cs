using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods2;

namespace ExtensionMethods
{
    public partial class Form1 : Form
    {
        string dsd = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            // string extension
            string s = "Hello Extension Methods";
            int i = s.WordCount();

            // extenstion method for cls class
            cls clsNew = new cls();
            string strCls = clsNew.extensionCls("call extension method");            

            // linq query
            int[] arr = { 1, 2, 3, 7, 4 };
            var rslt = from x in arr
                       where x > 2
                       select x;
            foreach (int y in rslt)
            {
                Console.WriteLine("y: " + y);
            }

            // lambda query - aici metoda "where" este o "extension method" 
            //importata prin using System.Linq si care se aplica la System.Collections.IEnumerable
            var z = arr.Where(g => g > 2);
            foreach (int z1 in z)
            {
                Console.WriteLine("z: " + z1);
            }
        }
    }

    public class cls
    {
        public void printCls()
        {
        }

        //if the method exists with the same name, then this will be used instead of the extension method
        //public string extensionCls()
        public string extensionCls2( string s)
        {
            return "base method cls" + s;
        }
    }
}
