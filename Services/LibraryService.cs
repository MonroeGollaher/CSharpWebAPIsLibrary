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

    public string DeleteBook(int index)
    {
      FakeDB.Books.RemoveAt(index);
      return "Your book has been removed from the library.";
    }

    public string ReadBook(int index)
    {
      string book = FakeDB.Books[index].Description;
      return book;
    }

    public Book GetOneBook(int index)
    {
      return FakeDB.Books[index];
    }

    public Book EditBook(Book editedBook, int index)
    {
        Book oldBook = FakeDB.Books[index];

        oldBook.Title = editedBook.Title;
        oldBook.Author = editedBook.Author;
        oldBook.Description = editedBook.Description;

        return oldBook;
    }
  }
}