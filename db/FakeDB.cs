using System.Collections.Generic;
using CSharpWebAPI.Models;

namespace CSharpWebAPI.db
{
    public static class FakeDB
    {
        public static List<Book> Books { get; set; } = new List<Book>()
        {
            new Book("Recipe Book", "Gordan Ramsay", "Yummy Food"),
            new Book("The Lord of the Rings", "J.R. Tokein", "Adventure"),
            new Book("Harry Potter", "J.K. Rowling", "Fantasy"),
            new Book("The Perks of Being a Wallflower", "Stephen Chbosky", "Epistolary"),
            new Book("1984", "George Orwell", "Science Fiction")
        };
    }
}