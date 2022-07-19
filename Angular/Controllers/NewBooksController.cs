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
        public HttpResponseMessage Books()
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

        [HttpPost]
        public HttpResponseMessage Booksearch(BooksModel model)
        {
            Books bookObj = new Books();
            BooksModel booksclassobj = new BooksModel();
            booksclassobj.categorieslist = bookObj.CategoriesGetList();
            booksclassobj.publisherslist = bookObj.PublishersGetList();
            bookObj.CategoryId = model.CategoryId;
            if (bookObj.CategoryId == "0") {
                bookObj.CategoryId = null;
            }
            bookObj.PublisherId = model.PublisherId;
            if (bookObj.PublisherId == "0")
            {
                bookObj.PublisherId = null;
            }
            bookObj.BookName = model.BookName;
            if (bookObj.BookName == "0")
            {
                bookObj.BookName = null;
            }
            booksclassobj.bookslist = bookObj.BooksGetList();
            return Request.CreateResponse(HttpStatusCode.Created, booksclassobj);
        }
    }
}
