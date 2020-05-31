using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linq2
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CityId { get; set; }
        public override string ToString() => $"{Id} , {FirstName} , {LastName}, {Age}, {CityId}";
    }
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }

    class Program
    {

        static void Main()
        {

            List<Student> _students = new List<Student>()
            {
            new Student()
                { Id = 1, FirstName = "Oleg", LastName = "Petrov", Age = 18, CityId = 3 },
            new Student()
                { Id = 2, FirstName = "Marina", LastName = "Ivanova", Age = 19, CityId = 2 },
            new Student()
                 { Id = 3, FirstName = "Taras", LastName = "Golovko", Age = 19, CityId = 2 },
            new Student()
                { Id = 4, FirstName = "Aleksei", LastName = "Smirnov", Age = 18, CityId = 1 },
            new Student()
                { Id = 5, FirstName = "Oleg", LastName = "Belov", Age = 21, CityId = 1}
            };
            List<City> _cities = new List<City>()
            {
                new City(){ Id = 1, CityName = "Dnepropetrovsk" },
                new City(){ Id = 2, CityName = "Kyiv" },
                new City(){ Id = 3, CityName = "Lvov" }
            };
            int[] arr1 = new int[] { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[] { 30, 40, 50, 60, 70, 80 };
            ArrayList arr3 = new ArrayList() { 1, 2, 3, "4", "5", "6", 7 };
            IEnumerable<int> arr4 = new List<int> { 00, 10, 20, 30, 40 };

            var sameSt = from st in _students
                         from ct in _cities
                         where st.CityId == ct.Id
                         group ct by ct.CityName into item
                         select new
                         {
                             Studs = from st in _students from ct in _cities where st.CityId == ct.Id where item.Key == ct.CityName select st,
                             Name = item.Key,
                             Count = item.Count()
                         };

            sameSt.ToList().ForEach(i => Console.WriteLine($"{i.Studs.Select(s => s.FirstName + " " + s.LastName).Aggregate((f, s) => f + " , " + s)} in {i.Name} : {i.Count}"));

            Console.WriteLine("\n\nall");
            arr1.Concat(arr2).ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine("\n\nuniq");
            arr1.Union(arr2).ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine("\n\nrepeatable");
            arr1.Intersect(arr2).ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine("\n\nfirst arr haven't elems from second");
            arr1.Except(arr2).ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine("\n\npick concrete type items from array\nint :");
            arr3.OfType<int>().ToList().ForEach(i => Console.Write($"{i} "));
            Console.WriteLine("\nstring :");
            arr3.OfType<string>().ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine("\n\ncities in dictionary where city id will be dictionary key");
            Dictionary<int, City> cityDic = _cities.ToDictionary(i => i.Id);
            cityDic.ToList().ForEach(i => Console.WriteLine($"key = {i.Key} Id = {i.Value.Id} {i.Value.CityName}"));

            Console.WriteLine("\nfirst equivalent element or null");
            Console.WriteLine(_students.FirstOrDefault(i => i.FirstName == "Olegs")?.Id);

            Console.WriteLine("\nexception if NOT uniq");
            try
            {
                Console.WriteLine(_students.SingleOrDefault(i => i.FirstName == "Oleg").Id);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine("\nelement at 5 :");
            Console.WriteLine(_students.ElementAtOrDefault(5)?.FirstName);

            Console.WriteLine("\ncount of multiples to 20 , min , max and average");
            Console.WriteLine($"{arr1.Count(i => i % 20 == 0)} {arr1.Where(i => i % 20 == 0).Min()} {arr1.Where(i => i % 20 == 0).Max()} {arr1.Average()}");

            Console.WriteLine("\ngen enum collection");
            Enumerable.Range(5, 12).ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine("\n\ngen repeat collection");
            Enumerable.Repeat(5, 12).ToList().ForEach(i => Console.Write($"{i} "));



            Console.ReadLine();
        }
    }
}
