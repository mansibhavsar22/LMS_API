using Angular.DAL;
using Angular.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Angular.Controllers
{
    public class BooksController : ApiController
    {
        // GET: Books
        public HttpResponseMessage Books(BooksModel model)
        {
            Books bookObj = new Books();
            BooksModel booksclassobj = new BooksModel();
            //BooksModel bookobjnew = (BooksModel)Session["Books"];
            booksclassobj.categorieslist = bookObj.CategoriesGetList();
            booksclassobj.publisherslist = bookObj.PublishersGetList();

            //if (bookobjnew != null)
            //{
            //    model = (BooksModel)Session["Books"];
            //}

            //if (Session["Books"] != null)
            //{
                booksclassobj.CategoryId = model.CategoryId;
                booksclassobj.PublisherId = model.PublisherId;
                booksclassobj.BookName = model.BookName;
                booksclassobj.PageNumber = model.PageNumber;
                booksclassobj.PageSize = model.PageSize;
            //}
            //Session["Books"] = null;
            //return View(booksclassobj);
            return Request.CreateResponse(HttpStatusCode.Created, booksclassobj);
        }

        //[HttpPost]
        //public ActionResult BooksJson(BooksModel model)
        //{
        //    Books bookObj = new Books();
        //    BooksModel b = new BooksModel();
        //    b.categorieslist = bookObj.CategoriesGetList();
        //    b.publisherslist = bookObj.PublishersGetList();

        //    bookObj.CategoryId = model.CategoryId;
        //    bookObj.PublisherId = model.PublisherId;
        //    bookObj.BookName = model.BookName;
        //    bookObj.PageNumber = model.PageNumber;
        //    bookObj.PageSize = model.PageSize;
        //    bookObj.publisherslist = b.publisherslist;
        //    bookObj.categorieslist = b.categorieslist;

        //    b.bookslist = bookObj.BooksGetList();
        //    Session["Books"] = model;
        //    b.PageSize = model.PageSize;
        //    b.PageNumber = model.PageNumber;
        //    b.TotalRecords = bookObj.TotalRecords;
        //    model.PageSize = bookObj.PageSize;
        //    b.count = Convert.ToInt32(b.bookslist[0].TotalRecords);
        //    b.TotalPages = (int)Math.Ceiling((double)b.count / b.PageSize);
        //    return PartialView("_BookList", b);
        //    // return Json(b, JsonRequestBehavior.AllowGet);
        //}

        //// GET: BooksInsert
        //public ActionResult BooksInsert(int id = 0)
        //{
        //    int BookId = id;
        //    Books bookObj = new Books();
        //    BooksModel booksclassobj = new BooksModel();
        //    booksclassobj.categorieslist = bookObj.CategoriesGetList();
        //    booksclassobj.publisherslist = bookObj.PublishersGetList();
        //    bookObj.publisherslist = booksclassobj.publisherslist;
        //    bookObj.categorieslist = booksclassobj.categorieslist;

        //    if (BookId > 0)
        //    {
        //        bookObj.BookId = BookId;
        //        bookObj.Load();
        //        booksclassobj.BookId = bookObj.BookId;
        //        booksclassobj.BookName = bookObj.BookName;
        //        booksclassobj.CategoryId = bookObj.CategoryId;
        //        booksclassobj.PublisherId = bookObj.PublisherId;
        //        booksclassobj.IsActive = bookObj.IsActive;
        //    }
        //    else
        //    {
        //        booksclassobj.categorieslist = bookObj.CategoriesGetList();
        //        booksclassobj.publisherslist = bookObj.PublishersGetList();
        //    }
        //    return View(booksclassobj);
        //}

        //[HttpPost]
        //public ActionResult BooksInsert(Books bookobj)
        //{
        //    Books bookObj = new Books();
        //    BooksModel booksclassobj = new BooksModel();
        //    booksclassobj.categorieslist = bookObj.CategoriesGetList();
        //    booksclassobj.publisherslist = bookObj.PublishersGetList();

        //    bookObj.BookId = bookobj.BookId;
        //    bookObj.BookName = bookobj.BookName;
        //    bookObj.CategoryId = bookobj.CategoryId;
        //    bookObj.PublisherId = bookobj.PublisherId;
        //    bookObj.IsActive = bookobj.IsActive;
        //    bookObj.publisherslist = booksclassobj.publisherslist;
        //    bookObj.categorieslist = booksclassobj.categorieslist;

        //    bookObj.Save();
        //    return Json("Saved Successfully");

        //    //return View(bookObj);
        //}

        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    Books bookObj = new Books();
        //    bookObj.BookId = id;
        //    bookObj.Delete();
        //    //return Json("Deleted successfully");
        //    return Json(bookObj, JsonRequestBehavior.AllowGet);
        //}
    }
}