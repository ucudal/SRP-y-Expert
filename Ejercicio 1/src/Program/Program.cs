using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            ShelveBook lib1 = new ShelveBook("A", "7");
            lib1.Books(book1);
            lib1.Books(book2);
            Console.WriteLine($"La libreria {lib1.Shelve} en el sector {lib1.Sector} contiene los libros: ");
            foreach(Book a in lib1.Libros)
            {
                Console.WriteLine(a.Title);
            }
        }
    }
}