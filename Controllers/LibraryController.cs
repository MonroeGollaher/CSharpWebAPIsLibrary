using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpWebAPI.Models;

namespace CSharpWebAPI.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        public readonly LibraryService _ls;

        public LibraryController(LibraryService libraryService)
        {
            _ls = libraryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            try
            {
                return Ok(_ls.GetBooks()); 
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<IEnumerable<Book>> AddBook([FromBody] Book newBook)
        {
            try
            {
                return Ok(_ls.AddBook(newBook));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{index}")]
        public ActionResult<string> DeleteBook(int index)
        {
            try
            {
                return Ok(_ls.DeleteBook(index));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{index}")]
        public ActionResult<IEnumerable<Book>> ReadBook(int index)
        {
            try
            {
                return Ok(_ls.ReadBook(index));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{index}")]
        public ActionResult<Book> GetOneBook(int index)
        {
            try
            {
                return Ok(_ls.GetOneBook(index)); 
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{index}")]
        public ActionResult<IEnumerable<Book>> EditBook([FromBody] Book editedBook, int index)
        {
            try
            {
                return Ok(_ls.EditBook(editedBook, index));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{inded}")]
        public ActionResult<IEnumerable<Book>> CheckoutBook(Book checkout, int index)
        {
            try
            {
                return Ok(_ls.CheckoutBook(checkout, index)); 
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

    }
}