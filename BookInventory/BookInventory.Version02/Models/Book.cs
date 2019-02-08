using System;
using System.ComponentModel.DataAnnotations;

namespace BookInventory.Version02.Models
{
    public class Book
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Author")]
        public string Author { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Public Domain")]
        public bool IsPublicDomain { get; set; }

        [Display(Name = "Publisher Email")]
        [DataType(DataType.EmailAddress)]
        public string PublisherEmail { get; set; }

        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}