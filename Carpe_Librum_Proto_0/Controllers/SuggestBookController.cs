using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Carpe_Librum_Proto_0.Models;

namespace Carpe_Librum_Proto_0.Controllers
{
    public class SuggestBookController : Controller
    {
        // GET: SuggestBook
        private SuggestBookDbContext db = new SuggestBookDbContext();

        public ActionResult Index()
        {
            List<SuggestBook> suggestBooks = db.SuggestedBooks.ToList();

            return View(suggestBooks);
        }
        //
        public ActionResult BookofTheMonth(int? id)
        {
            
            id = 1;
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            SuggestBook book = db.SuggestedBooks.Find(id);

            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult SuggestABook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SuggestABook(SuggestBook book)
        {
            if(ModelState.IsValid)
            {
                book.DateAdded = DateTime.Now; //Adds the date to the date it is now
                db.SuggestedBooks.Add(book); //Adds the new suggested book to the database
                db.SaveChanges(); 
                return View("Details", book); //Returns a view to the details page of that specific book
            }
            
            return View(book);
        }
        //Action for the details page
        public ActionResult Details(int? id)
        {
            //checks to see if the id is valid
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            //finds the id of the book
            SuggestBook book = db.SuggestedBooks.Find(id);

            //checkes to find if that id matches thes ones in the database
            if (book == null)
            {
                return HttpNotFound();
            }
            // if it finds the book returns the view for that book's details page to be displayed
            return View(book);
        }
    }
}