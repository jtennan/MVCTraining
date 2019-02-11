using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BookInventory.Version04.Models
{
    public class Book
    {
        public Book()
        {
            GenreList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Mystery", Value = "Mystery" },
                new SelectListItem { Text = "Biography", Value = "Biography" },
                new SelectListItem { Text = "Humor", Value = "Humor" },
            };
        }

        [Required(ErrorMessage = "Missing Title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Missing Author")]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Missing Genre")]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Public Domain")]
        public bool IsPublicDomain { get; set; }

        [Required(ErrorMessage = "Missing Email")]
        [Display(Name = "Publisher Email")]
        [DataType(DataType.EmailAddress)]
        public string PublisherEmail { get; set; }

        [Required(ErrorMessage = "Missing Published Date")]
        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        public IList<SelectListItem> GenreList { get; set; }
    }
}