using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQtoOBJexample
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int CityID { get; set; }

        public override string ToString() => $"{Id} , {Name} , {Surname} , {Age}";
    }

    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Id} , {Name}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<City> cities = new List<City>();
            for (int i = 0; i < 5; i++)
                cities.Add(new City() { Id = i + 1, Name = $"City{i + 1}" });
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
                students.Add(new Student() { Id = i + 1, Name = $"Name{i}", Surname = $"Surname{i}", Age = i + 11, City = cities.ElementAt(rnd.Next(0, cities.Count - 1)) });

            var wherEx = from s in students
                         where (s.Age > 18 && s.Name.Contains("ame"))
                         orderby s.Name descending
                         select s;

            var wherExLiam = students.Where(s => s.Age > 18 && s.Name.Contains("ame")).OrderByDescending(s => s.Name);

            var tekeExmpl = (from s in students
                             where !s.Name.Contains("1")
                             select s).Take(2);

            //var res = students.Join(cities,s=>s.CityID);

            foreach (var item in tekeExmpl)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
