using System;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile car = new Automobile("Packard", "Custom Eight", 1948);
            Console.WriteLine(car);

            PlayWithBooks();
            PlayWithShapes();
        }

        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            WriteLine($"{pub.Title}, " + $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}\n");

        }

        public static void PlayWithBooks()
        {
            var book = new Book("The Tempest", "0971655819", "Shakespeare, William", "Public Domain Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book);

            var book2 = new Book("The Tempest", "Classic Works Press", "Shakespeare, William");
            ShowPublicationInfo(book2);
            WriteLine($"{book.Title} and {book2.Title} are the same publication: " + $"{((Publication)book).Equals(book2)}\n");
        }

        public static void PlayWithShapes()
        {
            Shape[] shapes = { new Rectangle(10, 12), new Square(5), new Circle(3) };

            foreach (var shape in shapes)
            {
                WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " + $"perimeter, {Shape.GetPerimeter(shape)}");

                var rect = shape as Rectangle;
                if (rect != null)
                {
                    WriteLine($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }

                var sq = shape as Square;
                if (sq != null)
                {
                    Console.WriteLine($"   Diagonal: {sq.Diagonal}");
                    continue;
                }

                WriteLine();
            }
        }
    }
}

