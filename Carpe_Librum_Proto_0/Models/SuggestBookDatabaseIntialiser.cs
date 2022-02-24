using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Carpe_Librum_Proto_0.Models
{
    public class SuggestBookDatabaseIntialiser : DropCreateDatabaseAlways<SuggestBookDbContext>
    {
        protected override void Seed(SuggestBookDbContext context)
        {
            SuggestBook b1 = new SuggestBook
            {
                BookTitle = "The Picture of Dorian Gray",
                BookAuthor= "Oscar Wilde",
                BookPublisher="Lippincott's Monthly Magazine",
                BookDate= 1890,
                DateAdded = new DateTime(2014, 10, 21)
            };
            SuggestBook b2 = new SuggestBook
            {
                BookTitle = "Frakenstein: The 1818",
                BookAuthor = "Mary Wollstonecraft Shelly",
                BookPublisher = "Lackington, Hughes, Harding, Mavor & Jones",
                BookDate = 1818,

                
                DateAdded = new DateTime(2020, 9 , 11)
                

            };
            SuggestBook b3 = new SuggestBook
            {
                BookTitle = "Dracula",
                BookAuthor = "Bram Stoker",
                BookPublisher = "Archibald Constable and Company (UK)",
                BookDate = 1897,
                DateAdded = new DateTime(2005,12, 1)

            };
            SuggestBook b4 = new SuggestBook
            {
                BookTitle = "Jane Eyre",
                BookAuthor = "Charlotte Bronte",
                BookPublisher = "	Smith, Elder & Co.",
                BookDate = 1847,
                DateAdded = new DateTime(2021, 3, 1)

            };
            SuggestBook b5 = new SuggestBook
            {
                BookTitle = "Pride and Prejudice",
                BookAuthor = "Jane Austen",
                BookPublisher = "T. Egerton, Whitehall",
                BookDate = 1813,
                DateAdded = new DateTime(2012, 6 , 14)

            };
            SuggestBook b6 = new SuggestBook
            {
                BookTitle = "The Adventures of Huckleberry Finn",
                BookAuthor = "Mark Twain",
                BookPublisher = "Chatto & Windus / Charles L. Webster And Company.",
                BookDate = 1885,
                DateAdded = new DateTime(2012,6,1)
                

            };

            context.SuggestedBooks.Add(b1);
            context.SuggestedBooks.Add(b2);
            context.SuggestedBooks.Add(b3);
            context.SuggestedBooks.Add(b4);
            context.SuggestedBooks.Add(b5);
            context.SuggestedBooks.Add(b6);
            context.SaveChanges();

            base.Seed(context);
        }
    }

            
 }

