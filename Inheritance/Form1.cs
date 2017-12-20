using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //A a = new A(" instanceA");
            //a.printNew();
            //a.printVirtual();

            //B b = new B(" instanceB");
            //b.printNew();
            //b.printVirtual();
            //((A)b).printNew();
            //((A)b).printVirtual();

            //A ab = new B(" instanceAB");
            //ab.printNew();
            //ab.printVirtual();

            one o = new one();
            bool x = o.Equals(1);
        }
    }

    class A
    {
        internal A(string s) { Console.WriteLine("From base class: " + s); }
        public void printNew() { Console.WriteLine("Print New from base class: "); }
        public virtual void printVirtual() { Console.WriteLine("Print Virtual from base class: "); }
    }
    class B : A
    {
        internal B(string s) : base(s) { Console.WriteLine("From derived class: " + s); }
        public new void printNew() { Console.WriteLine("Print New from derived class: "); }
        public override void printVirtual() { Console.WriteLine("Print Virtual from derived class: "); }
    }

    // abstract classes
    // nu pot fi create instance pentru clasele abstracte
    abstract class abstrA
    {
        public void printSimple() { }
        public abstract void printAbstract(string s);
    }
    class abstrB : abstrA
    {
        public override void printAbstract(string s) { }
    }

    //interface
    interface IMyInterfaceA
    {
        void print(string s);
    }
    class implementInterfaceB : IMyInterfaceA
    {
        public void print(string s) { }
    }

    class one : IEquatable<int>
    {
        int x = 1;
        public bool Equals(int other)
        {
            return x == other;
        }
    }
}

