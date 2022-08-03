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
            booksclassobj.PageSize = bookObj.PageSize;
            booksclassobj.PageNumber = bookObj.PageNumber;
            booksclassobj.TotalRecords = bookObj.TotalRecords;
            booksclassobj.count = Convert.ToInt32(booksclassobj.bookslist[0].TotalRecords);
            booksclassobj.TotalPages = (int)Math.Ceiling((double)booksclassobj.count / bookObj.PageSize);
            booksclassobj.bookslist = bookObj.BooksGetList();
            booksclassobj.PageSize = bookObj.PageSize;
            return Request.CreateResponse(HttpStatusCode.Created, booksclassobj);
        }

        [HttpPost]
        public HttpResponseMessage Booksearch(BooksModel model)
        {
            Books bookObj = new Books();
            BooksModel booksclassobj = new BooksModel();
            booksclassobj.categorieslist = bookObj.CategoriesGetList();
            booksclassobj.publisherslist = bookObj.PublishersGetList();
            if (bookObj.CategoryId == "0")
            {
                bookObj.CategoryId = null;
            }
            bookObj.CategoryId = model.CategoryId;
            if (bookObj.PublisherId == "0")
            {
                bookObj.PublisherId = null;
            }
            bookObj.PublisherId = model.PublisherId;
            if (bookObj.BookName == "")
            {
                bookObj.BookName = null;
            }
            bookObj.BookName = model.BookName;
            bookObj.PageSize = model.PageSize;
            bookObj.PageNumber = model.PageNumber;
            booksclassobj.bookslist = bookObj.BooksGetList();
            booksclassobj.TotalRecords = bookObj.TotalRecords;
            booksclassobj.count = Convert.ToInt32(booksclassobj.bookslist[0].TotalRecords);
            booksclassobj.TotalPages = (int)Math.Ceiling((double)booksclassobj.count / bookObj.PageSize);
            booksclassobj.bookslist = bookObj.BooksGetList();
            booksclassobj.PageSize = bookObj.PageSize;
            return Request.CreateResponse(HttpStatusCode.Created, booksclassobj);
        }

        [HttpGet]
        public HttpResponseMessage BookInsert(int Id = 0)
        {
            int BookId = Id;
            Books bookObj = new Books();
            BooksModel booksclassobj = new BooksModel();
            booksclassobj.categorieslist = bookObj.CategoriesGetList();
            booksclassobj.publisherslist = bookObj.PublishersGetList();
            bookObj.publisherslist = booksclassobj.publisherslist;
            bookObj.categorieslist = booksclassobj.categorieslist;
            bookObj.BookId = BookId;
            bookObj.Load();
            booksclassobj.BookId = bookObj.BookId;
            booksclassobj.BookName = bookObj.BookName;
            booksclassobj.CategoryId = bookObj.CategoryId;
            booksclassobj.PublisherId = bookObj.PublisherId;
            booksclassobj.IsActive = bookObj.IsActive;
            return Request.CreateResponse(HttpStatusCode.Created, booksclassobj);
        }

        [HttpPost]
        public HttpResponseMessage BookInsertPost(Books bookobj)
        {
            Books bookObj = new Books();
            BooksModel booksclassobj = new BooksModel();
            booksclassobj.categorieslist = bookObj.CategoriesGetList();
            booksclassobj.publisherslist = bookObj.PublishersGetList();

            bookObj.BookId = bookobj.BookId;
            bookObj.BookName = bookobj.BookName;
            bookObj.CategoryId = bookobj.CategoryId;
            bookObj.PublisherId = bookobj.PublisherId;
            bookObj.IsActive = bookobj.IsActive;
            bookObj.Save();
            return Request.CreateResponse(HttpStatusCode.Created,1);
        }

        [HttpPost]
        public HttpResponseMessage Delete(Books bookobj)
        {
            Books bookObj = new Books();
            bookObj.BookId = bookobj.BookId;
            bookObj.Delete();
            return Request.CreateResponse(HttpStatusCode.Created, 1);
        }
    }
}
