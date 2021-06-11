using Hibasys.BookStore.Models;
using Hibasys.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hibasys.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepo = null;

        public BookController()
        {
            _bookRepo = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepo.GetAllBook();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepo.GetBookById(id);
        }

        public List<BookModel> SearchBook(string Title, string author)
        {
            return _bookRepo.SearchBook(Title, author);
        }
    }
}
