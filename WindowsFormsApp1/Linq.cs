using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Linq
    {
        public Linq()
        { Linq2(); }
        public void Linq2()
        {
            string[] words = { "apples", "blueberries", "oranges", "bananas", "apricots" };

            // Create the query.
            var wordGroups1 =
                from w in words                
                group w by w[0] into fruitGroup
                where fruitGroup.Count() >= 2
                select new { FirstLetter = fruitGroup.Key, Words = fruitGroup.Count() };

            // Execute the query. Note that we only iterate over the groups, 
            // not the items in each group
            foreach (var item in wordGroups1)
            {
                Console.WriteLine(" {0} has {1} elements.", item.FirstLetter, item.Words);
            }            
        }

        //Join
        //var innerJoinQuery =
        //from category in categories
        //join prod in products on category.ID equals prod.CategoryID
        //select new { ProductName = prod.Name, Category = category.Name }; //produces flat sequence

        public void Linq1()
        {
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //var numQuery =
            //    from num in numbers
            //    where (num % 2) == 0
            //    select num;

            //foreach(int n in numQuery)
            //{
            //    Console.WriteLine(n);
            //}            

            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                orderby student.Scores[0] descending
                select student;

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }

            var std =
                from stud in students
                where stud.Scores[0] > 70 && stud.First.Equals("Claire")
                orderby stud.Scores[0]
                select stud;

            foreach (Student s in std)
            {
                Console.WriteLine(s.First);
            }

            var studentQuery2 =
                from student in students
                group student by student.Last;

            // studentGroup is a IGrouping<char, Student>
            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("   {0}, {1}", student.Last, student.First);
                }
            }
        }


        static List<Student> students = new List<Student>
{
   new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
   new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
   new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
   new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
   new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
   new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
   new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
   new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
   new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
   new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
   new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
   new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
};
    }
}
