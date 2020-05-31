using System;
using System.Collections.Generic;
using System.Linq;

namespace linqHW
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department() { Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department() { Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department() { Id = 3, Country = "France", City = "Paris" },
                new Department() { Id = 4, Country = "Russia", City = "Moscow" } };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Tamara" , LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee() { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee() { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27, DepId = 4 }
            };

            Console.WriteLine("\n1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.");
            PrintUAnotDonetskInLine(departments, employees);
            Console.WriteLine("\n2) Вывести список стран без повторений.");
            PrintDistincCountries(departments);
            Console.WriteLine("\n3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.");
            Top3EmpOlder25(employees);
            Console.WriteLine("\n4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года.");
            EmpFromKyivOlder23(employees, departments);
            Console.ReadLine();
        }

        /// 1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.
        public static void PrintUAnotDonetsk(List<Department> departments, List<Employee> employees)
        {
            var res = departments.Where(d => d.City != "Donetsk" && d.Country == "Ukraine").Join(employees, d => d.Id, e => e.DepId, (d, e) => new { e.FirstName, e.LastName });

            foreach (var i in res)
                Console.WriteLine($"{i.FirstName} , {i.LastName}");
        }

        public static void PrintUAnotDonetskInLine(List<Department> departments, List<Employee> employees) => departments.Where(d => d.City != "Donetsk" && d.Country == "Ukraine").Join(employees, d => d.Id, e => e.DepId, (d, e) => new { e.FirstName, e.LastName }).ToList().ForEach(i => Console.WriteLine($"{i.FirstName} , {i.LastName}"));

        /// 2) Вывести список стран без повторений.
        public static void PrintDistincCountries(List<Department> departments)
        {
            var res = (from d in departments
                       select d.Country).Distinct();

            var res1 = departments.Select(d => d.Country).Distinct();

            foreach (var item in res1)
                Console.WriteLine(item);
        }


        /// 3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.
        public static void Top3EmpOlder25(List<Employee> employees)
        {
            var res = employees.Where(e => e.Age > 25).Take(3);

            foreach (var item in res)
                Console.WriteLine(item);
        }

        /// 4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года.
        public static void EmpFromKyivOlder23(List<Employee> employees, List<Department> departments)
        {
            var res = departments.Where(d => d.City == "Kyiv").Join(employees, d => d.Id, e => e.DepId, (d, e) => new { e.FirstName, e.LastName, e.Age }).Where(e => e.Age > 23);

            foreach (var i in res)
                Console.WriteLine($"{i.FirstName} , {i.LastName} , {i.Age}");
        }

    }

}
