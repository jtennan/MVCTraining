using System;
using System.ComponentModel.DataAnnotations;

namespace BookInventory.Version03.Models
{
    public class Book
    {
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
    }
}