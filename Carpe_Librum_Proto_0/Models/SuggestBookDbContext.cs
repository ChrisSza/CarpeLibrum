using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Carpe_Librum_Proto_0.Models
{
    public class SuggestBookDbContext:DbContext
    {
        public DbSet<SuggestBook> SuggestedBooks { get; set; }

        public SuggestBookDbContext() :base("SuggestABook_22")
        {
            Database.SetInitializer(new SuggestBookDatabaseIntialiser());
        }
    }
}