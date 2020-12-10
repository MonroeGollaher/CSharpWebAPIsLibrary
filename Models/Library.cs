using System.Collections.Generic;

namespace CSharpWebAPI.Models
{
    public class Library
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
       public Library(string name, string location)
       {
           Name = name; 
           Location = location;
       } 

    }
}