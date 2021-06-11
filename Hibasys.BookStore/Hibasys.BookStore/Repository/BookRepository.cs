using Hibasys.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hibasys.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }

        public BookModel GetBookById(int bookID)
        {
            return DataSource().Where(x => x.ID == bookID).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string strTitle, string strAuthor)
        {
            return DataSource().Where(x => x.Title.Contains(strTitle) || x.Author.Contains(strAuthor)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {ID=1,Author="Shoyeb Ahmad" , Title="MVC "},
                new BookModel() {ID=2,Author="Hiba Aziz" , Title="Java"},
                new BookModel() {ID=3,Author="Jameel Ahmad" , Title="C#"},
                new BookModel() {ID=4,Author="Riyaz Bhai" , Title="C++"},
                new BookModel() {ID=5,Author="Nusrat Sultana" , Title="Dot Net"},
                new BookModel() {ID=6,Author="Shoyeb Ahmad" , Title="SQL Server"},
                new BookModel() {ID=7,Author="Hiba Aziz" , Title="VB"},
                new BookModel() {ID=8,Author="Hiba Aziz" , Title="Angular"},
                new BookModel() {ID=9,Author="Imtiyaz" , Title="Java"},
                new BookModel() {ID=10,Author="Shoyeb Ahmad" , Title="C#"},

            };
        }
    }
}
