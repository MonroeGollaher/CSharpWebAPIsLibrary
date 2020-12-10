using System;
using System.Collections.Generic;
using CSharpWebAPI.db; 
using CSharpWebAPI.Models; 


namespace CSharpWebAPI.Services
{
  public class LibraryService
  {
    public IEnumerable<Book> GetBooks()
    {
      return FakeDB.Books;
    }

    public Book AddBook(Book newBook)
    {
      FakeDB.Books.Add(newBook);
      return newBook;
    }
  }
}