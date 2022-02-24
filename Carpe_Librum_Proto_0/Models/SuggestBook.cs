using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Carpe_Librum_Proto_0.Models
{
    public class SuggestBook
    {
        [Key]
        public int BookId { get; set; }

        [Display(Name = "Title")]
        public string BookTitle { get; set; }

        [Display(Name = "Author")]
        public string BookAuthor { get; set; }

        [Display(Name = "Publisher")]
        public string BookPublisher { get; set; }

        [Display(Name = "Date Published")]
        public int BookDate { get; set; }

        [Display(Name = "Date Suggested")]

        [DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }


    }
}