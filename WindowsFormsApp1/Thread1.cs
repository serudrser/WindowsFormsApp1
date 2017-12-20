using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public class Thread1
    {
        public Thread1()
        {
            AreaClass ac = new AreaClass();
            ac.Base = 30;
            ac.Height = 40;
            Thread t = new Thread(ac.CalcArea);
            t.Start();
        }
    }

    class AreaClass
    {
        public double Base;
        public double Height;
        public double Area;
        public void CalcArea()
        {
            Area = 0.5 * Base * Height;
            MessageBox.Show("The area is: " + Area.ToString());
        }
    }
}
