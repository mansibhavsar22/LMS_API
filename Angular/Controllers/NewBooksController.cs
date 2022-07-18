using Angular.DAL;
using Angular.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular.Controllers
{
    public class NewBooksController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Books(BooksModel model)
        {
            Books bookObj = new Books();
            BooksModel booksclassobj = new BooksModel();
            booksclassobj.categorieslist = bookObj.CategoriesGetList();
            booksclassobj.publisherslist = bookObj.PublishersGetList();
            booksclassobj.CategoryId = bookObj.CategoryId;
            booksclassobj.PublisherId = bookObj.PublisherId;
            booksclassobj.BookName = bookObj.BookName;
            booksclassobj.bookslist = bookObj.BooksGetList();
            return Request.CreateResponse(HttpStatusCode.Created, booksclassobj);
        }
    }
}
