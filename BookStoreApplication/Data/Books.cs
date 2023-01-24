using System;
using System.Collections;
using System.Collections.Generic;

namespace BookStoreApplication.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int TotalPage { get; set; }
        public int LanguageId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Language Language { get; set; }
        public string CoverImgUrl { get; set; }
        public string BookPdfUrl { get; set; }
        public ICollection<BookGallery> bookGallery { get; set; }
    }
}
