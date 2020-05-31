using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Task 1
            List<Good> goods1 = new List<Good>() {
                new Good() { Id = 1, Title = "Nokia 1100", Price = 450.99, Category = "Mobile" },
                new Good() { Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile" },
                new Good() { Id = 3, Title = "Refregirator 5000", Price = 2555, Category = "Kitchen" },
                new Good() { Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen" },
                new Good() { Id = 5, Title = "Magnitola", Price = 1499, Category = "Car" }
            };

            List<Good> goods2 = new List<Good>() {
                new Good() { Id = 6, Title = "Samsung Galaxy", Price = 3100, Category = "Mobile" },
                new Good() { Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
                new Good() { Id = 8, Title = "Owen", Price = 700, Category = "Kitchen" },
                new Good() { Id = 9, Title = "Siemens Turbo", Price = 3199, Category = "Mobile" },
                new Good() { Id = 10, Title = "Lighter", Price = 150, Category = "Car" }
            };

            //Рассматривать как одну коллекцию.
            var gAndg = goods1.Concat(goods2);


            Console.WriteLine("Выбрать товары категории Mobile, цена которых превышает 1000 грн.:");
            gAndg.Where(i => i.Category == "Mobile" && i.Price > 1000).ToList().ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\nВывести название и цену тех товаров, которые не относятся к категории Kitchen, цена которых превышает 1000 грн.:");
            gAndg.Where(i => i.Category != "Kitchen" && i.Price > 1000).ToList().ForEach(i => Console.WriteLine($"{i.Title} {i.Price}"));

            Console.WriteLine("\nВывести название товара и его категорию, который имеет максимальную цену:");
            Console.WriteLine(gAndg.OrderByDescending(i => i.Price).Select(i => i.Title + " " + i.Category).FirstOrDefault());

            Console.WriteLine($"\nВычислить среднее значение всех цен товаров:");
            Console.WriteLine(gAndg.Average(i => i.Price));

            Console.WriteLine("\nВывести список категорий без повторений:");
            gAndg.Select(i => i.Category).Distinct().ToList().ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\nВывести названия тех товаров, цены которых совпадают:");
            gAndg.GroupBy(i => i.Price).ToList().ForEach(i =>
            {
                if (i.Count() > 1)
                    i.ToList().ForEach(inner => Console.WriteLine(inner.Title));
            });
            #region same solution
            /*
            foreach (var item in gAndg.GroupBy(i => i.Price))
                if (item.Count() > 1)
                    foreach (var i in item)
                        Console.WriteLine(i.Title);
             */
            #endregion

            Console.WriteLine($"\nВывести названия и категории товаров в алфавитном порядке, упорядоченных по названию:");
            gAndg.OrderBy(i => i.Title).ToList().ForEach(i => Console.WriteLine($"{i.Title} {i.Category}"));

            Console.WriteLine($"\nПроверить, содержит ли категория Car товары, с ценой от 1000 до 2000 грн.");
            Console.WriteLine(gAndg.Where(i => i.Category == "Car").Any(i => i.Price > 1000 && i.Price < 2000));

            Console.WriteLine($"\nПосчитать суммарное количество товаров категорий Сar и Mobile:");
            Console.WriteLine(gAndg.Where(i => i.Category == "Car" || i.Category == "Mobile").Sum(i => i.Price));

            Console.WriteLine($"\nВывести список категорий и количество товаров каждой категории:");
            gAndg.GroupBy(i => i.Category).Select(i => new { Cat = i.Key, Count = i.Count() }).ToList().ForEach(i => Console.WriteLine($"{i.Cat} - {i.Count}"));
            #endregion

            #region Task 2
            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };

            var vAndv = values1.Concat(values2);

            Console.WriteLine("\nПосчитать среднее значение четных элементов, которые больше 10:");
            Console.WriteLine(vAndv.Where(i => i > 10 && i % 2 == 0).Count() > 0 ? vAndv.Where(i => i > 10 && i % 2 == 0).Average() : default);

            Console.WriteLine("\nВыбрать только уникальные элементы из массивов values1 и values2:");
            values1.Union(values2).ToList().ForEach(i => Console.Write(i + " "));

            Console.WriteLine("\n\nНайти максимальный элемент массива values2, который есть в массиве values1:");
            Console.WriteLine(values2.Intersect(values1).Max(i => i));

            Console.WriteLine("\nПосчитать сумму элементов массивов values1 и values2, которые попадают в диапазон от 5 до 15");
            Console.WriteLine(vAndv.Where(i => i > 5 && i < 15).Count());

            Console.WriteLine("\nОтсортировать элементы массивов values1 и values2 по убыванию:");
            vAndv.OrderByDescending(i => i).ToList().ForEach(i => Console.Write(i + " "));
            #endregion

            Console.ReadKey();
        }
    }

    public class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public override string ToString() => $"{Id} {Title} {Price} {Category}";
    }
}
