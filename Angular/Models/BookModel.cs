﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular.DAL;

namespace Angular.Models
{
    public class BooksModel
    {
        public int BookId { get; set; }

        //[Required(ErrorMessage = "BookName is required.")]
        public string BookName { get; set; }
        //public string BookDescription { get; set; }
        public int BookQuantity { get; set; }
        //[Required(ErrorMessage = "PublisherName is required.")]
        public string PublisherName { get; set; }

        //[Required(ErrorMessage = "CategoryName is required.")]
        public string CategoryName { get; set; }

        //[Required(ErrorMessage = "PublisherId is required.")]
        public string PublisherId { get; set; }

        //[Required(ErrorMessage = "CategoryId is required.")]
        //public int CategoryId { get; set; }

        public string CategoryId { get; set; }

        //[Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public List<Books> bookslist { get; set; }
        public List<Books> categorieslist { get; set; }
        public List<Books> publisherslist { get; set; }
       // public List<IssueBooks> IssueBookList { get; set; }
        public int TotalRecords { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalPages { get; set; } 
        public int count { get; set; }
        public int IssueId { get; set; }
        public DateTime IssueDate { get; set; }
        public int UserId { get; set; }
    }
}