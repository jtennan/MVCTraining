using System;

namespace BookInventory.Version01.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsPublicDomain { get; set; }
        public string PublisherEmail { get; set; }
        public DateTime PublishDate { get; set; }
    }
}