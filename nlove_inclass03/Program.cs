using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_inclass03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names_array = new string[] {"Masha", "Natasha", "Barbara", "Josh", "Don"};

            List<string> names = new List<string>(names_array);//- takes space and prepopulates// also can put a number in (5) - limits space to 5 names- doesn't populate
            // Lists can be enlarged

            Console.WriteLine(names[3]);
            names.Add("Sally");
            names.AddRange(new string[] { "Dave", "Eve" });

            Console.WriteLine(names.Contains("Masha"));
            Console.WriteLine(names.Contains("Luda"));

            Console.WriteLine(names.IndexOf("Greg"));
            Console.WriteLine(names.IndexOf("Don"));
            Console.WriteLine();


            names.Remove("Dave");
            names.RemoveAt(names.LastIndexOf("Don"));// RemoveAt(index)

            Console.WriteLine(names.Count);// will put the amount of items in the list currently

            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(120);
            numbers.Add(60);
            numbers.Add(97);
            numbers.Add(101);

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine();


            Dictionary<int, string> Students = new Dictionary<int, string>();
            Students.Add(1, "Brandon"); // 1 their ID - here - can also use a string as ID
            Students.Add(2, "Matt");
            Students.Add(3, "Olga");
            Students.Add(4, "Sam");

            Console.WriteLine("________________________");
            Console.WriteLine(Students.ContainsValue("Matt"));
            
            Console.WriteLine("________________________");

            Students.Remove(1);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            //foreach loop with Dictionary - uses general variable - var
            foreach (var Student in Students)
            {
                Console.WriteLine(Student.Key);
                Console.WriteLine(Student.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
