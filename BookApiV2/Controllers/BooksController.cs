﻿using BookApiV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApiV2.Controllers
{
    // https://localhost:????/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{ Id = 1, Author = "Author One", Title = "Book One" },
            new Book{ Id = 2, Author = "Author Two", Title = "Book Two" },
            new Book{ Id = 3, Author = "Author Three", Title = "Book Three" },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks() 
        {
            return Ok(_books);
        }
    }
}
