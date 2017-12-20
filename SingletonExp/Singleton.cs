using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExp
{
    public class tst
    {
        public tst()
        {
            Singleton s1 = Singleton.Instance;
            Singleton s11 = Singleton.Instance;
            //s1.methodX();
            s1.varX = 2;
            Console.WriteLine(s11.varX);

            // varX has the same value for s1 and s2
            Singleton2 s2 = Singleton2.Instance;
        }
    }

    //1
    public class Singleton
    {
        private static Singleton singletonInstance = CreateSingleton();
        public int varX = 1;

        private Singleton()
        {
        }

        private static Singleton CreateSingleton()
        {
            if (singletonInstance == null)
            {
                singletonInstance = new Singleton();
            }

            return singletonInstance;
        }

        public static Singleton Instance
        {
            get { return singletonInstance; }
        }

        public void methodX() { }
    }

    //2
    public sealed class Singleton2
    {
        private static Singleton2 instance = null;
        private static readonly object padlock = new object();

        Singleton2()
        {
        }

        public static Singleton2 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
            }
        }
    }
}
