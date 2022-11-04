using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace linq_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 часть задания
            string[] months = {"January","February","March","April","May","June","July","August","September",
                "October","November","December"};

            int length = 5;
            Console.WriteLine("Месяца отсортированные по длине 5");
            var selectbylentgh = months.Where(m => m.Length == length);
            foreach (string sorted in selectbylentgh)
                Console.WriteLine(sorted);
            Console.WriteLine();


            Console.WriteLine("Месяца отсортированные в алфавитном порядке");
            var selectbyalphaber = months.OrderBy(m => m);
            foreach (string sorted in selectbyalphaber)
                Console.WriteLine(sorted);
            Console.WriteLine();


            Console.WriteLine("Месяца седержащие букву u и длиной имени не менее 4х символов");
            var countandlength = months.Where(m => (m.Length >= 4) && (m.Contains('u')));
            foreach (string sorted in countandlength)
                Console.WriteLine(sorted);
            Console.WriteLine();


            Console.WriteLine("Только летние и зимние месяца");
            var onlywinterandsummer = months.Where(m => (m == "February") || (m == "January") || (m == "December")
            || (m == "June") || (m == "July") || (m == "August"));
            foreach (string sorted in onlywinterandsummer)
                Console.WriteLine(sorted);
            Console.WriteLine();
           

            //2 часть задания
            List<Book> books = new List<Book>();
            books.Add(new Book("SomeTitle1", "SomeAuthor1", new DateTime(2012, 9, 12), 20, 4000));
            books.Add(new Book("SomeTitle2", "SomeAuthor2", new DateTime(2010, 5, 20), 105, 10000));
            books.Add(new Book("SomeTitle3", "SomeAuthor3", new DateTime(2020, 4, 1), 10, 1500));
            books.Add(new Book("SomeTitle4", "SomeAuthor2", new DateTime(2014, 3, 20), 30, 2500));
            books.Add(new Book("SomeTitle5", "SomeAuthor1", new DateTime(2008, 4, 29), 300, 20500));
            books.Add(new Book("SomeTitle6", "SomeAuthor2", new DateTime(2021, 7, 14), 25, 5000));
            books.Add(new Book("SomeTitle7", "SomeAuthor3", new DateTime(2000, 1, 1), 50, 500));


            Console.WriteLine("Книги за авторством SomeAuthor1\n");
            var sortedbyauthor = books.Where(b => b.Author == "SomeAuthor1").Select(b => b.Title);
            foreach (string somerequest in sortedbyauthor)
                Console.WriteLine(somerequest);
            Console.WriteLine();


            Console.WriteLine("Книги выпущенные после 2010 года");
            var aftersomedate = books.Where(b => b.DateOfPublish.Year > 2010).Select(b => b.Title);
            foreach (string somerequest in aftersomedate)
                Console.WriteLine(somerequest);
            Console.WriteLine();


            Console.WriteLine("Самая тонка книга");
            var mostthinbook = books.OrderBy(b => b.NumberOfPages).Select(b=>b.Title).First();
            Console.WriteLine(mostthinbook);
            Console.WriteLine();


            Console.WriteLine("5 самых толстых книг");
            var most5fatbooks = books.OrderByDescending(b => b.NumberOfPages).Take(5).Select(b=>b.Title);
            foreach (string somerequest in most5fatbooks)
                Console.WriteLine(somerequest);
            Console.WriteLine();


            Console.WriteLine("Книги отсортированные по цене");
            var sortedbyprice = books.OrderBy(b => b.Price).Select(b=>new
            {
                Title = b.Title,
                Price = b.Price
            });
            foreach (var somerequest in sortedbyprice)
                Console.WriteLine(somerequest.Title +" Цена: " +somerequest.Price);
            Console.WriteLine();

        }
    }
}


