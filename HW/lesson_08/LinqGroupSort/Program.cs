using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqGroupSort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region init data
            List<Department> departments = new List<Department>() {
                new Department() { Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department() { Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department() { Id = 3, Country = "France", City = "Paris" },
                new Department() { Id = 4, Country = "Russia", City = "Moscow" }
            };

            List<Employee> employees = new List<Employee>() {
                new Employee() { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee() { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee() { Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4 }
            };
            #endregion

            Console.WriteLine("Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине. Выполнить запрос немедленно.");
            var uaByNameThenSurname = departments.Where(d => d.Country == "Ukraine").Join(employees, d => d.Id, e => e.DepId, (d, e) => new { e.FirstName, e.LastName }).OrderBy(e => e.FirstName).ThenBy(e => e.LastName).ToList();
            Console.WriteLine(uaByNameThenSurname.Select(i => i.FirstName + " " + i.LastName).Aggregate((f, s) => f + "\n" + s));


            Console.WriteLine("\nОтсортировать сотрудников по возрастам, по убыванию. Вывести Id, FirstName, LastName, Age. Выполнить запрос немедленно.");
            List<Employee> byAge = employees.OrderByDescending(e => e.Age).ToList();
            Console.WriteLine(byAge.Select(i => i.Id + " " + i.FirstName + " " + i.LastName + " " + i.Age).Aggregate((f, s) => f + "\n" + s));


            Console.WriteLine("\nСгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается в списке.\nlegacy linq:");
            var sameAge = from e in employees
                          group e by e.Age into item
                          select new
                          {
                              item.Key,
                              Count = item.Count()
                          };
            // or
            var empGroupAge = employees.GroupBy(i => i.Age).Select(i => new { i.Key, Count = i.Count() }).ToList();
            Console.WriteLine(sameAge.ToList().Select(i => i.Key.ToString() + " - " + i.Count + " times").Aggregate((f, s) => f + "\n" + s));
            Console.WriteLine("\nlyambda:");
            empGroupAge.ForEach(i => Console.WriteLine($"{i.Key} - {i.Count} times"));

            Console.ReadKey();
        }
    }


    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepId { get; set; }
    }

    class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }

}
