using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class LambdaExample3
    {
        public LambdaExample3()
        {
            exp1(); // use method OrderBy - This method has at least one parameter of type Expression<TDelegate> whose type argument is one of the Func<T,TResult> types. For these parameters, you can pass in a lambda expression and it will be compiled to an Expression<TDelegate>

            AllEx1(); // use method All
            AllEx2(); // use method All also
        }
        public void exp1()
        {
            Person3 p1 = new Person3 { Name = "Kayes", Age = 29, JoiningDate = DateTime.Parse("2010-06-06") };
            Person3 p2 = new Person3 { Name = "Gibbs", Age = 34, JoiningDate = DateTime.Parse("2008-04-23") };
            Person3 p3 = new Person3 { Name = "Steyn", Age = 28, JoiningDate = DateTime.Parse("2011-02-17") };

            List<Person3> persons = new List<Person3>();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            List<Person3> sortedList = persons.OrderBy<Person3, int>(p => p.Age).ToList();
            List<Person3> sortedList2 = persons.OrderBy(p => p.Age).ToList();

            Person3[] ar = new Person3[] { p1, p2, p3 };
            Person3[] ar2 = { p1, p2, p3 };
            Person3[] arSort = ar.OrderBy(p => p.Age).ToArray();
        }
        public void AllEx1()  // This code produces the following output: Not all pet names start with 'B'. 
        {
            // Create an array of Pets.
            Pet[] pets = { new Pet { Name="Barley", Age=10 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=6 } };

            // Determine whether all pet names in the array start with 'B'.
            bool allStartWithB =
                pets.AsQueryable().All(pet => pet.Name.StartsWith("B"));

            Console.WriteLine(
                "{0} pet names start with 'B'.",
                allStartWithB ? "All" : "Not all");
        }


        public static void AllEx2()
        {
            List<PersonAllExp> people = new List<PersonAllExp>
        { new PersonAllExp { LastName = "Haas",
                       Pets = new Pet[] { new Pet { Name="Barley", Age=10 },
                                          new Pet { Name="Boots", Age=14 },
                                          new Pet { Name="Whiskers", Age=6 }}},
          new PersonAllExp { LastName = "Fakhouri",
                       Pets = new Pet[] { new Pet { Name = "Snowball", Age = 1}}},
          new PersonAllExp { LastName = "Antebi",
                       Pets = new Pet[] { new Pet { Name = "Belle", Age = 8} }},
          new PersonAllExp { LastName = "Philips",
                       Pets = new Pet[] { new Pet { Name = "Sweetie", Age = 2},
                                          new Pet { Name = "Rover", Age = 13}} }
        };

            // Determine which people have pets that are all older than 5.
            IEnumerable<string> names = from person in people
                                        where person.Pets.AsQueryable().All(pet => pet.Age > 5)
                                        select person.LastName;

            foreach (string name in names)
                Console.WriteLine(name);

            /* This code produces the following output:
             * 
             * Haas
             * Antebi
             */
        }
    }
    public class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime JoiningDate { get; set; }
    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class PersonAllExp
    {
        public string LastName { get; set; }
        public Pet[] Pets { get; set; }
    }
}
