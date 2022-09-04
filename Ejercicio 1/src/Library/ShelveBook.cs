using System;
using System.Collections.Generic;
namespace SRP 
{
    public class ShelveBook
    {
        public List<Book> Libros = new List<Book>();
        public string Sector { get ; }
        public string Shelve { get ; }
        public string Book { get ; }


        public ShelveBook (string sector, string shelve){
            this.Sector = sector;
            this.Shelve = shelve;
        }
        public void Books(Book book){
            this.Libros.Add(book);
        }
    }
}    