﻿using WebAPIDemo.Entites;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class BookService : IBookServices
    {
        private readonly IBookRepositories repo
        public BookService(IBookRepositories repo)
        {
            this.repo = repo;
        }
        public int AddBook(Book book)
        {
           return repo.AddBook(book);
        }

        public int DeleteBook(int id)
        {
            
            return repo.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return repo.GetBooks();
        }

        public int UpdateBook(Book book)
        {
            
            return repo.UpdateBook(book);
        }
    }
}
