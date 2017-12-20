using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class IEnumerator___IEnumerable
    {
        public IEnumerator___IEnumerable()
        {
            exp1();
        }

        public void exp1()
        {
            Garage carLot = new Garage();
            // Hand over each car in the collection?
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",
                c.name, c.mph);
            }

            // Manually work with IEnumerator.
            IEnumerator i = carLot.GetEnumerator();
            i.MoveNext();
            Car myCar = (Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH", myCar.name, myCar.mph);
        }
    }

    public class Garage:IEnumerable
    {
        private Car[] carArray = new Car[4];
        // Fill with some Car objects upon startup.
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }
        public IEnumerator GetEnumerator()
        {
            // Return the array object's IEnumerator.
            return carArray.GetEnumerator();
        }
    }
    public class Car
    {
        public string name = "";
        public int mph = 0;

        public Car(string name, int mph)
        {
            this.name = name;
            this.mph = mph;
        }
    }

    //// This interface allows the caller to
    //// obtain a container's subitems.
    //public interface IEnumerator
    //{
    //    bool MoveNext(); // Advance the internal position of the cursor.
    //    object Current { get; } // Get the current item (read-only property).
    //    void Reset(); // Reset the cursor before the first member.
    //}

    class exp1 : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class exp2 : IEnumerable<Int32>
    {
        public IEnumerator<Int32> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
