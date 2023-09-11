﻿using WebAPIDemo.Entites;

namespace WebAPIDemo.Repositories
{
    public interface IBookRepositories
    {
        IEnumerable<Book>GetBooks();
        Book GetBookById(int id);
        int AddBook(Book book);

        int UpdateBook(Book book);
        int DeleteBook(int id);
    }
}